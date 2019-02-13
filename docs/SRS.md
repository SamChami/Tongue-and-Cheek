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

##  5.3  Functional Requirements by CSC

###  5.3.1
The user GUI will be very minimal. At most, it will show when the player's tongue rope is deployed.

###  5.3.2 Tongue mechanic
The user will be able to deploy a tongue rope via the left click button. The tongue has two uses, based on the location of the pointer when the tongue is deployed

#### 5.3.2.1
If the user's pointer is significantly above (more than 60 degrees from the ground) the character and connects with an anchor, the player's tongue will act as a rope, allowiing for the user to swing back and forth, thus releasing their tongue via a second left click

#### 5.3.2.2
If the user's pointer is below the threshold (less than 60 degrees from the ground) and connects with an anchor, the player's tongue will act as a speed grappling hook. The tongue will propel the anchor forward and over the anchor, thus progressing it through the level.

### 5.3.3 Anchor mechanic
The player is given the ability to connect to anchors around the map via its tongue rope. The anchors will be disguised within the map, although will have some stylistic properties to let it stand out. As it stands, anchors will be more heavily outlined and likely on a separate layer. Some anchors will be placed around the map not as a means for progressing the player through the map, but rather as a diversion from the actual goal.

##  5.4  Performance Requirements by CSC

###  5.4.1  Logging in or Registering
TODO

###  5.4.2 Creating a New Activity
TODO

###  5.4.3 Selecting an Activity Banner
TODO

###  5.4.4 Locating Features to Use in Group Chat Environment
TODO

##  5.5  Project Environment Requirements

###  5.5.1  Development Environment Requirements

####  5.5.1.1 Android Development

#####  5.5.1.1.1 Android Studio for Android Phone Emulator

#####  5.5.1.1.2 Mac, Windows, or Linux System

####  5.5.1.2 iPhone Development

#####  5.5.1.2.1 Xcode

#####  5.5.1.2.2 An iPhone

###  5.5.2  Execution Environment Requirements
