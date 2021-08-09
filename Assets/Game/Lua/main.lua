local ECS = require "ECS"
local json = require "json"

local w = ECS.fetch_world("Admin")

w:register("vector2", {
	x = 0,
	y = 0,
})

w:register("vector3", {
	x = 0,
	y = 0,
	z = 0
})

local key = {}

for i = 1, 10 do
	local k = {}
	key[i] = k
	print("new", w:new {
		__uniquekey = k,
		vector2 = {x = i, y = i},
		--vector3 = {x = i, y = i, z = i}
	})
end


print("========SELECT")
local list, n = w:select("vector2")
for i = 1, n do
	local e = list[i]
	if e.vector2.x % 5 == 0 then
		w:modify(e)
	end
	print(json.encode(e))
end

print(json.encode(w:select("UNIQUE", key[1])))

print("========MODIFY")
local list, n = w:select("MODIFY")
for i = 1, n do
	local e = list[i]
	print(json.encode(e))
end

print("========MAKE DEAD")
local list, n = w:select("vector2")
for i = 1, n do
	local e = list[i]
	if i % 5 == 0 then
		w:del(e)
	end
	print(json.encode(e))
end

print("========MODIFY")
local list, n = w:select("MODIFY")
for i = 1, n do
	local e = list[i]
	print(json.encode(e))
end

print("========DEAD")
local list, n = w:select("DEAD", "vector2")
for i = 1, n do
	local e = list[i]
	print(json.encode(e))
end

print("========DUMP")
w:dump()
print("========UPDATE")
w:update()
print("========DUMP")
w:dump()

