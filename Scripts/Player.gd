extends KinematicBody


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
const SPEED = 30
var velocity = Vector3(0,0,0)

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.
	

# Called every frame, before physics process
# warning-ignore:unused_argument
func _physics_process(delta):
	if Input.is_action_just_pressed("ui_right") and Input.is_action_just_pressed("ui_left"):
		velocity.x=0
	elif Input.is_action_just_pressed("ui_right"):
		velocity.x=SPEED
	elif Input.is_action_just_pressed("ui_left"):
		velocity.x=-SPEED
	else:
		velocity.x=lerp(velocity.x,0,0.01)
		
	if Input.is_action_just_pressed("ui_up") and Input.is_action_just_pressed("ui_down"):
		velocity.z=0
	elif Input.is_action_just_pressed("ui_up"):
		velocity.z=-SPEED
	elif Input.is_action_just_pressed("ui_down"):
		velocity.z=SPEED
	else:
		velocity.z=lerp(velocity.z,0,0.01)
	
	move_and_slide(velocity)
	
	
	#pass
# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
