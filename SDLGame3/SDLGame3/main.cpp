#include <SDL.h>
#include <SDL_image.h>
#include <SDL_ttf.h>
#include <SDL_mixer.h>

#include <string>
using namespace std;

//boolean to maintain program loop
bool quit = false;

//deltaTime int() - for fram rate ind
float deltaTime = 0.0f;
int thisTime = 0;
int lastTime = 0;

//player movement - controlled by keypress, not deltaTime
int playerMovement = 71;

//create rectangles for menu graphics
SDL_Rect playerPos;

//NEW PATROLLING 1 ********************************************

#include "enemy.h"
#include <vector>

vector<Enemy> enemyList;

int numberOfEnemies;

//NEW PATROLLING 1 END ********************************************

//NEW INVENTORY 1 **********************************************
#include "coin.h"

vector<Coin> coinList;

int numberOfCoins;

Mix_Chunk* pickup;

//NEW INVENTORY 1 END **********************************************


int main(int argc, char* argv[])
{
	SDL_Window* window;  //declare a pointer

	//create a renderer
	SDL_Renderer* renderer = NULL;

	SDL_Init(SDL_INIT_EVERYTHING);  //initialize SDL2

	//create an application window with the following settings:
	window = SDL_CreateWindow(
		"Space Rocks",   //window title
		SDL_WINDOWPOS_UNDEFINED,    //initial x position
		SDL_WINDOWPOS_UNDEFINED,    //initial y position
		642,    //width, in pixels
		358,    //height, in pixels
		SDL_WINDOW_OPENGL    //flags - see below
	);

	//check that the window was successfully created
	if (window == NULL)
	{
		//in the case that the window could not be made
		printf("Could not create window: %s\n", SDL_GetError());
		return 1;
	}

	//create renderer
	renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

	//background image -- CREATE

	SDL_Surface* surface = IMG_Load("./Assets/level.png");

	//create level texture
	SDL_Texture* level;

	//place surface into level texture
	level = SDL_CreateTextureFromSurface(renderer, surface);

	//free the surface
	SDL_FreeSurface(surface);

	//create rectangles for the level position
	SDL_Rect levelPos;

	//set levelPos x, y, width and height
	levelPos.x = 0;
	levelPos.y = 0;
	levelPos.w = 642;
	levelPos.h = 358;

	//background image -- CREATE END

	//player image -- CREATE

	//create a sdl surface
	surface = IMG_Load("./Assets/player.png");

	//create player texture
	SDL_Texture* player;

	//place surface into player texture
	player = SDL_CreateTextureFromSurface(renderer, surface);

	//free the surface
	SDL_FreeSurface(surface);

	//set playerPos x, y, width and height
	playerPos.x = 291;
	playerPos.y = 291;
	playerPos.w = 59;
	playerPos.h = 59;

	//player image -- CREATE END


	//sdl event to handle input
	SDL_Event event;

	//maze settings - width and height
	const int mazeWidth = 9;
	const int mazeHeight = 5;

	//create the array for the maze - 'O' for open space, 'W' for wall, 'P' for player
	string maze[mazeHeight][mazeWidth] = {
		{"O","O","O","O","O","O","O","O","O"},
		{"O","W","O","W","W","W","O","W","O"},
		{"O","O","O","O","W","O","O","O","O"},
		{"O","W","O","W","W","W","O","W","O"},
		{"O","O","O","O","P","O","O","O","O"}
	};

	//player starting position in the maze Row 5 Column 5 = [4][4]
	int playerHorizontal = 4;
	int playerVertical = 4;

	//NEW PATROLLING 2 ********************************************

	enemyList.clear();


	numberOfEnemies = 4;

	Enemy tempEnemy(renderer, 71, 2, 2, "left", "CCW", 575, 7);

	enemyList.push_back(tempEnemy);

	Enemy tempEnemy2(renderer, 71, 2, 2, "right", "CW", 7, 7);

	enemyList.push_back(tempEnemy2);

	Enemy tempEnemy3(renderer, 71, 2, 2, "right", "CW", 433, 149);

	enemyList.push_back(tempEnemy3);

	Enemy tempEnemy4(renderer, 71, 2, 2, "up", "CCW", 149, 291);

	enemyList.push_back(tempEnemy4);

	//NEW PATROLLING 2 END ********************************************

	//NEW INVENTORY 2 **********************************************

	coinList.clear();

	numberOfCoins = 4;

	int totalCoins = 0;

	Coin tempCoin(renderer, 18, 18);

	coinList.push_back(tempCoin);

	Coin tempCoin2(renderer, 18, 302);

	coinList.push_back(tempCoin2);

	Coin tempCoin3(renderer, 586, 18);

	coinList.push_back(tempCoin3);

	Coin tempCoin4(renderer, 586, 302);

	coinList.push_back(tempCoin4);

	Mix_OpenAudio(44100, MIX_DEFAULT_FORMAT, 2, 2048);

	pickup = Mix_LoadWAV("./Assets/pickup.wav");

	//NEW INVENTORY 2 END **********************************************


	//basic program loop
	while (!quit)
	{
		//create deltaTime
		thisTime = SDL_GetTicks();
		deltaTime = (float)(thisTime - lastTime) / 1000;
		lastTime = thisTime;

		//check for input
		if (SDL_PollEvent(&event))
		{
			//close window by the window's x button
			if (event.type == SDL_QUIT)
			{
				quit = true;
			}

			switch (event.type)
			{
				/*Look for a keypress*/
			case SDL_KEYUP:
				
				switch (event.key.keysym.sym)
				{
				case SDLK_RIGHT: //move right

					//check to see if the player's potential horizontal postion is within the maze's right side limit
					if ((playerHorizontal + 1) < mazeWidth)
					{
						if (maze[playerVertical][playerHorizontal + 1] == "O")
						{
							//move player position in array
							maze[playerVertical][playerHorizontal + 1] = "P";

							maze[playerVertical][playerHorizontal] = "O";

							//increase playerHorizontal by 1
							playerHorizontal += 1;

							//increase player position x by 71 - move right
							playerPos.x += playerMovement;
						}
					}

					

					break;

				case SDLK_LEFT: //move left
					
					//check to see if the player's potential horizontal position is within the maze's left side limit
					if ((playerHorizontal - 1) >= 0)
					{
						if (maze[playerVertical][playerHorizontal - 1] == "O")
						{
							//move player position in array
							maze[playerVertical][playerHorizontal - 1] = "P";

							maze[playerVertical][playerHorizontal] = "O";

							//decrease playerHorizontal by 1
							playerHorizontal -= 1;

							//decrease player position x by 71 - move left
							playerPos.x -= playerMovement;
						}
					}

					break;

				case SDLK_UP: //move up

					//check to see if the player's potential vertical position is within the maze's up limit
					if ((playerVertical - 1) >= 0)
					{
						if (maze[playerVertical - 1][playerHorizontal] == "O")
						{
							maze[playerVertical - 1][playerHorizontal] = "P";

							maze[playerVertical][playerHorizontal] = "O";

							//decrease playerVertical by 1
							playerVertical -= 1;

							//decrease player position y by 71 - move up
							playerPos.y -= playerMovement;
						}
					}
					break;

				case SDLK_DOWN: //move down

					//check to see if the player's potential vertical position is within the maze's down limit
					if ((playerVertical + 1) < mazeHeight)
					{
						if (maze[playerVertical + 1][playerHorizontal] == "O")
						{
							maze[playerVertical + 1][playerHorizontal] = "P";

							maze[playerVertical][playerHorizontal] = "O";

							//increase playerVertical by 1
							playerVertical += 1;

							//increase player position y by 71 - move down
							playerPos.y += playerMovement;
						}
					}

					break;

				default:

					break;
				}
				break;
			}
		}

		//START UPDATE ************************************

		//update enemy list
		for (int i = 0; i < numberOfEnemies; i++)
		{
			enemyList[i].Update(deltaTime);
		}

		for (int i = 0; i < enemyList.size(); i++) 
		{
			if (SDL_HasIntersection(&playerPos, &enemyList[i].posRect))
			{
				cout << "You have lost!!" << endl;
				quit = true;
			}
		}

		for (int i = 0; i < coinList.size(); i++)
		{
			if (SDL_HasIntersection(&playerPos, &coinList[i].posRect))
			{
				Mix_PlayChannel(-1, pickup, 0);

				coinList[i].RemoveFromScreen();

				totalCoins++;

				cout << "Total Coins Collected: " + to_string(totalCoins) << endl;

				if (totalCoins == 4)
				{
					cout << "You have won!!" << endl;
					quit = true;
				}
			}
		}


		//END UPDATE **************************************

		//START DRAW **************************************

		//draw section
		//clear the old buffer
		SDL_RenderClear(renderer);

		//prepare to draw bkgd
		SDL_RenderCopy(renderer, level, NULL, &levelPos);

		//draw player
		SDL_RenderCopy(renderer, player, NULL, &playerPos);

		for (int i = 0; i < numberOfCoins; i++)
		{
			coinList[i].Draw(renderer);
		}

		//draw enemy list
		for (int i = 0; i < numberOfEnemies; i++)
		{
			enemyList[i].Draw(renderer);
		}

		//draw new info to the screen
		SDL_RenderPresent(renderer);


		//END DRAW **************************************

	}//ends game loop

	//close and destroy the window
	SDL_DestroyWindow(window);

	//clean up
	SDL_Quit();

	return 0;

}