# Super-Paper-Mario-Level-Editor-Randomizer

A basic level editor for Super Paper Mario with enemy randomization capabilities.

Uses Wiims' WIT for Wii ISO extraction and repacking.

# Usage

Unpack a Super Paper Mario Wii ISO using the File->Extract ISO command.

Next click on "Open setup folder" and navigate to the DATA/files folder. Select the "setup" folder there.
This will open the list of levels in the game.

On the left side, you can pick the level to edit. On the right, a list of enemies will appear along with their data.


To randomize the game, select Randomization -> Randomize using preset, and choose one from the "Presets" folder.
You can also customize how the game is randomized using the preset editor.

After you're done, select "Save all". The filesystem can be loaded directly in Dolphin by opening "main.dol" from the DATA/sys folder,
or you can rebuild the iso using the "Pack ISO" option.
