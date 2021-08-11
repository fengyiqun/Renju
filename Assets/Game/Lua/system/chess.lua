local ECS = require "ECS"
local json = require "json"
local place_chess = GamePlay.Utils.PlaceChess


local w = ECS.fetch_world("Admin")



local function update()
	local list, n = w:select("MODIFY", "Chess")
	for i = 1, n do
		local e = list[i]
		e.GameObject = place_chess(e.Chess.x, e.Chess.y, e.Chess.side == "white" and 1 or 0)
	end
end

return update

