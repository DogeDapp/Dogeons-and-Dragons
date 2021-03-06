﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogHouseController : MonoBehaviour
{

    public PlayerConfig myPlayer;

    public Image[] dogButtons;

    public Image[] dogImages;
    public ArrayOfDogs dougs;

    public void setActive(DogStatsConfig currentDog)
    {
        //TODO: sets to active
        //TODO: checks dogs for active ones
        //TODO: loads in current team
    }

    public void initDogButtons()
    {
        for (int i = 0; i < dougs.dogsInTheGame.Length; i++)
        {
            dogButtons[i].sprite = dougs.dogsInTheGame[i].head;
            if (myPlayer.hasDog(dougs.dogsInTheGame[i]))
            {
                dogButtons[i].color = new Color(1, 1, 1, 1);
            }
            else
            {
                dogButtons[i].color = new Color(0, 0, 0, 1);
            }
        }
    }

    public void initTeamPortraits()
    {
        for (int i = 0; i < myPlayer.yourTeam.Length; i++)
        {
            if (myPlayer.yourTeam[i] == null)
            {
                dogImages[i].sprite = null;
                dogImages[i].color = new Color(0, 0, 0, 0);
            }
            else
            {
                dogImages[i].sprite = myPlayer.yourTeam[i].head;
                dogImages[i].color = new Color(1, 1, 1, 1);
            }

        }
    }

    public void testCurrency(int i)
    {
        myPlayer.currency += i;
    }

    public void playerSet(PlayerConfig newPlayer)
    {
        myPlayer = newPlayer;
    }

    void Start()
    {

        initDogButtons();
        initTeamPortraits();
    }

    // Update is called once per frame
    void Update()
    {

    }
}