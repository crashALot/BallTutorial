﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{   
    // Go to Main Menu
    public void LoadMainMenu()
    {   // Is there a better way to do this than hardcoding?
        SceneManager.LoadScene("MainMenu");
    }

	// Select and load maze
    public void LoadMaze()
    {   
        SceneManager.LoadScene("galleryPic");
    }

    // Start the Game
    public void LoadGame()
    {   // Will the maze to load be controlled by global variable?
        SceneManager.LoadScene("MazeGame");
    }

    // Go to Instructions
    public void LoadInstructions()
    {   
        SceneManager.LoadScene("Instructions");
    }

    // Go to Options
    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    // Go to Win Scene
    public void LoadWin()
    {
        SceneManager.LoadScene("WinGame");
    }

    // Exit the application
    public void Quit()
    {
        Application.Quit();
    }
}
