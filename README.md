# MG7
## Devlog
I have attached my TreeOfBirds script to the Tree and have made the birds pop out only when the player comes near the tree. In this case, I am using an array that contains all my Sparrow objects except Sparrow_Start. This makes it more convenient for me to check all the birds instead of writing individual scripts for them. I have created a foreach loop in the Update function where the distances are checked between the Player and every element of this array. For calculating the distance between the two entities, I used Vector3.Distance, where the positions of both entities are Vector3 (containing three coordinates in 3D space). The script will set the bird's GameObject's active value to true when its distance is smaller than the interaction radius.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
