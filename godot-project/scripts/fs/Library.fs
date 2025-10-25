namespace fs

open Godot

module HelloFS =
    let currentModuleName = "HelloFS"
    let ready = fun() ->
        GD.Print("Hello from F#")

