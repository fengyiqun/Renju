local ECS = require "ECS"
local json = require "json"

local w = ECS.fetch_world("Admin")

local con_count<const> = 4
local axis_min<const> = 0
local axis_max<const> = 15

local function idx(x, y)
	return y * 100 + x;
end

local function check_line(grids, xx, yy, side, xdelta, ydelta)
	local n = 0
	local xstart = xx - con_count * xdelta;
	local xstop = xx + con_count * xdelta;
	local ystart = yy - con_count * ydelta;
	local ystop = yy + con_count * ydelta;
	if xdelta == 0 then
		local x = xx
		for y = yy - ydelta, ystart, -ydelta do
			local c = grids[idx(x,y)]
			c = c and c.Chess
			if c and c.side == side then
				n = n + 1
			else
				break
			end
		end
		for y = yy + ydelta, ystop, ydelta do
			local c = grids[idx(x,y)]
			c = c and c.Chess
			if c and c.side == side then
				n = n + 1
			else
				break
			end
		end
	elseif ydelta == 0 then
		local y = yy
		for x = xx - xdelta, xstart, -xdelta do
			local c = grids[idx(x,y)]
			c = c and c.Chess
			if c and c.side == side then
				n = n + 1
			else
				break
			end
		end
		for x = xx + xdelta, xstop, xdelta do
			local c = grids[idx(x,y)]
			c = c and c.Chess
			if c and c.side == side then
				n = n + 1
			else
				break
			end
		end
	else
		for x = xx - xdelta, xstart, -xdelta do
			for y = yy - ydelta, ystart, -ydelta do
				local c = grids[idx(x,y)]
				c = c and c.Chess
				if c and c.side == side then
					n = n + 1
				else
					break
				end
			end
		end
		for x = xx + xdelta, xstop, xdelta do
			for y = yy + ydelta, ystop, ydelta do
				local c = grids[idx(x,y)]
				c = c and c.Chess
				if c and c.side == side then
					n = n + 1
				else
					break
				end
			end
		end
	end
	print("check_line", xx, yy, "count", n)
	return n >= con_count
end

local function check_finish(grids, xx, yy, side)
	return check_line(grids, xx, yy, side, 0, 1) or check_line(grids, xx, yy, side, 1, 0) or check_line(grids, xx, yy, side, -1, 1) or check_line(grids, xx, yy, side, 1, -1) 
end

local function update()
	local board = w:select("Board")[1].Board
	local list, n = w:select("MODIFY", "Chess")
	local grids = board.grids
	for i = 1, n do
		local chess = list[i].Chess
		if check_finish(grids, chess.x, chess.y, chess.side) then
			board.over = true
			print("update finish")
			--TODO: mark finish, the show the result dialog
			break
		end
	end
end

return update

