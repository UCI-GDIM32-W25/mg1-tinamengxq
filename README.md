[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
1. Tina Meng, she/her/hers
2. In my plan, player's action will inform the existence of seed. So I use if statement to check whether the player pressed "Space" key. If the player presses "Space" and there is seed left, I use Instantiate() to call the prefab _plantPrefab to appear at the position of the player. Thus, I created a prefab of the picture of seed in unity and add player.cs to player gameobject. Secondly, the existence of seed will inform the UI and the UI of number of seeds remaining and planted will change on the screen. Initially in the script provided by professor, there is a public void UpdateSeeds (int seedsLeft, int seedsPlanted) method. I put this in the if statement after the Instantiate() method. This method changes the number in the UI text. I added plantcountUI.cs to canvas to connect UI to the player. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
