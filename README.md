# flappybird
Flappy Bird style demo game for Garycom

Following are the modifiers to Change the gameplay as requested

- GAME SPEED can be changed through game manager script in the inspector named game_speed
- OBSTACLES DISTANCE between each obstacles can be changed through Obstacles_Pool script attached to Obstacles_Pool gameobject, Distance Between Columns is the variable name to change the distance, its a range, and its set to minimum value which is 8, going below will make the game impossible to play, therefore slider is restricted to set to minimum of 8 value.
- GAP INCREMENT BETWEEN OBSTACLES, with this variable we can change how much we want the pass through area. currently the pass through area is very small, and increment is set to 0, if we want to increase the gap/pass through area, we can change this property.
- JUMP FORCE, in order to change the jump hieght of the bird, this can be changed in the inspector window of "Bird" GameObject under Bird_Controller component.
