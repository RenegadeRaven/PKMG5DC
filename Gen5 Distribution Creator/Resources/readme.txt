Pokémon Duodecuple Distribution
by Prof. 9
Version v1.4.1 "Skinless"

Features:
- Multiple Wonder Cards in a single distro ROM
- Ignores date restrictions
- Automatically fixes Wonder Card checksums

How to generate a 12-distro ROM:
1. Put a clean Liberty Ticket distro ROM in the tools folder, name it ticket.nds
2. In the tools folder, edit options.asm to fit your needs (optional)
3. Fire up 12distro.bat and use option 1 to create a base 12-distro ROM
4. Extract Wonder Cards from other distro ROMs using option 2
5. Place all the Wonder Cards you want in the cards folder, name them XX.bin
6. Use option 3 to compile a 12-distro ROM with the cards you want

Credits/Thanks:
- Kingcom (ARMIPS)
- DarkFader (ndstool)
- cearn (grit)
- Yellow Wood Goblin (slot-1 read fix)

Changelog:
  v1.4.1 "Skinless" - 21st May 2013
    - Liberty Ticket ROM should now be named ticket.nds.
    - Settings placed in their own file, options.asm.
    - Removed background image support; this seems to fix compatibility with a
      whole bunch of flashcards.

  v1.4 - 21st April 2011
    - Changed the patcher
    - Top screen background image support
    - Added a whole bunch of new options to 12distro.asm such as menu position,
      text alignment, colors, etc.

  v1.3 - 17th April 2011
    - Added automatic checksum fix for corrupted Wonder Cards.
    - Included some extra .bat files to quickly extract/compile.

  v1.2 - 4th April 2011
    - Now uses the NDS system firmware language for the Wonder Card names.
    - Uses a newer version of ndstool (doesn't really matter, though).
    - You can now specify in the .asm file at which half-a-line it starts
      writing Wonder Card names.

  v1.1 - 25th March 2011
    - Fixed a slot-1 read access bug, increasing compatibility. Thanks to Yellow
      Wood Goblin.

  v1.0 - 24th March 2011
    - Initial release.