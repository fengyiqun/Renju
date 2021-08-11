local ECS = require "ECS"
local json = require "json"

local input = require "system.input"
local board = require "system.board"
local chess = require "system.chess"
local judge = require "system.judge"

local w = ECS.fetch_world("Admin")

---------------register component

w:register("Input", {
	press = false,
	x = 0,
	y = 0,
})

w:register("Board", {
	over = false,
	side = "white",
	grids = {}
})

w:register("GameObject", {
	go = false
})

w:register("Chess", {
	x = 0,
	y = 0,
	side = 0,
})

--initialize, create entity

w:new {
	Input = { press = false, x = 0, y = 0		},
	Board = { over = false, side = "white", grids = {} 	}
}

-----------------------------

function Update()
	input()
	board()
	chess()
	judge()
	w:update()
end

function FixedUpdate()

end
