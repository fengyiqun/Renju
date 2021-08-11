local ECS = require "ECS"
local json = require "json"


local w = ECS.fetch_world("Admin")

local function idx(x, y)
	return y * 100 + x;
end

local function update()
	local input = w:select("Input")[1].Input
	if input.press then
		local x, y = input.x, input.y
		local id = idx(x, y)
		local board = w:select("Board")[1].Board
		local grids = board.grids
		if grids[id] then
			--TODO should push event into other component, then process in other system
			return
		end
		print("board.side", board.side)
		local e = {
			Chess = {x = x, y = y, side = board.side},
			GameObject = { go = false }
		}
		grids[id] = e
		w:new(e)
		w:modify(e)
		if board.side == "white" then
			board.side = "black"
		else
			board.side = "white"
		end
	end
end

return update

