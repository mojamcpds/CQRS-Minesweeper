﻿Feature: Starting a game
	In order to play a game of Minesweeper
	As a player 
	I want to be able to view the minefield

Scenario: Start a game
	Given I have not started a game		
	When I navigate to the game play page
	And click start a new game with a minefield size of 9 x 9
	Then I should see a minefield 9 x 9 full of tiles	
