local ECS = require "ECS"
local get_touch = GamePlay.Utils.GetTouch

local w = ECS.fetch_world("Admin")

local function update()
	local input = w:select("Input")[1].Input
	local board = w:select("Board")[1].Board
	if board.over then
		input.press = false
		return
	end
	input.press = get_touch(input)
	if input.press then
		print(input.x, input.y)
	end
end

return update


