#  Software Requirements Specification

##  5.1  Introduction
Inspired by QWOP and Getting Over it, 2D games with simple yet ridiculous game mechanics, Tongue and Cheek is a 2D side scroller game following a similar concept. As of right now, Tongue and Cheek is a light-hearted game featuring a single-player character progressing through time constrained individual levels using the mouse and the WASD keys. Tongue and Cheek is created for everyone.

##  5.2  CSCI Component Breakdown

###  5.2.1 GUI Client CSC
TODO

####  5.2.1.1 Client Login/Registration Screen CSU
TODO

####  5.2.1.2 Client Activities List Panel CSU
TODO

#####  5.2.1.2.1 ActivityBanner module
TODO

####  5.2.1.3 Client Current Activity Screen CSU
TODO

A Simple Mockup of our current CSCI is shown below.
![Mockup](images/components-concept-001.png)

##  5.3  Performance Requirements
###  5.3.1  Loading Screen Time

####  5.3.1 Max Load Screen Time
The application shall transition from the beginning of a non-playable loading screen back to gameplay or a menu within 7 seconds.

###  5.3.2 Tongue mechanic
The user will be able to deploy a tongue rope via the left click button. The tongue has two uses, based on the location of the pointer when the tongue is deployed

#### 5.3.2.1
If the user's pointer is significantly above (more than 60 degrees from the ground) the character and connects with an anchor, the player's tongue will act as a rope, allowiing for the user to swing back and forth, thus releasing their tongue via a second left click

#### 5.3.2.2
If the user's pointer is below the threshold (less than 60 degrees from the ground) and connects with an anchor, the player's tongue will act as a speed grappling hook. The tongue will propel the anchor forward and over the anchor, thus progressing it through the level.

### 5.3.3 Anchor mechanic
The player is given the ability to connect to anchors around the map via its tongue rope. The anchors will be disguised within the map, although will have some stylistic properties to let it stand out. As it stands, anchors will be more heavily outlined and likely on a separate layer. Some anchors will be placed around the map not as a means for progressing the player through the map, but rather as a diversion from the actual goal.

##  5.4  Environment Requirements

The following are the hardware requirements for Tongue and Cheek:

| Category         | Requirement           |
| ---------------- | --------------------- |
| Processor        | 2.7 GHz Intel Core i5 |
| Hard Drive Space | 1 GB                  |
| RAM              | 4 GB                  |
| Display          | 1280×720, 256 colors  |
| Sound Card       | Optional              |

The exceptional RAM requirement is necessary to support the detailed sprite animation and graphical images. These graphical demands require a large amount of RAM. There will be limited sound functionality unless the user has a sound card.


The following are the software requirements for Tongue and Cheek:

| Category         | Requirement              |
| ---------------- | ------------------------ |
| Operating System | macOS Mojave, Windows 10 |
| Compiler         | Unity; C++/C#            |
| Graphics         | Adobe Photoshop          |

macOS Mojave or Windows 10 is required for this project. Because of the scope of the project, there will be no attempt to test the program under macOS Mojave or Windows 10. The program will be written in C++/C# using Unity. Adobe Photoshop will be used to produce the graphical images and sprites for the project.
