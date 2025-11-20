using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SpeedTree.Importer;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class Worldstate : MonoBehaviour
{
    public object Instance { get; private set; }
    [SerializeField] private IconsUI iconsUI;

    private string currentLocation; // current "state" the player is in
    private string[] locationHistory = new string[9]; // stores every visited location
    private int numPlacesVisited;
    private int dayNumber;
    private int hoursLeft;
    private static int totalHours = 12;
    private double food;
    private double water;
    private double fuel;
    private int numPeopleInCar;
    private string[] peopleInCar = {"", "", "", ""};


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        locationHistory[0] = "Florida"; // setting first location on startup
        ResetHours();
        water = 5;
        fuel = 5;
    }

    public void SetLocation(string newLocation)
    {
        locationHistory[numPlacesVisited] = newLocation; // adding new visit to location list
        numPlacesVisited++; // incrementing number of visits
        currentLocation = newLocation; 
    }

    public void ChangePeopleInCar(string name)
    {
        for (int i = 0; i < 4; i++)
        {
            // if the person is in the car, remove them
            if (name == peopleInCar[i])
            {
                peopleInCar[i] = "";
            }
        }
        // else, replace first empty slot with that person
        for (int i = 0; i < 4; i++)
        {
            // if the person is in the car, remove them
            if (peopleInCar[i] == "")
            {
                peopleInCar[i] = name;
            }
        }
    }

    public void ResetHours()
    {
        hoursLeft = totalHours;
    }

    public string[] GetPeopleInCar()
    {
        return peopleInCar;
    }

    public string GetLocation()
    {
        return currentLocation;
    }

    public double GetHoursLeft()
    {
        return hoursLeft;
    }

    public void ChangeHoursLeft(int diff)
    {
        hoursLeft -= diff;
        iconsUI.UpdateIcons();
    }

    public double GetFood()
    {
        return food;
    }

    public void ChangeFood(double diff)
    {
        food += diff;
        iconsUI.UpdateIcons();
    }

    public double GetWater()
    {
        return water;
    }

    public void ChangeWater(double diff)
    {
        water += diff;
        iconsUI.UpdateIcons();
    }

    public double GetFuel()
    {
        return fuel;
    }

    public void ChangeFuel(double diff)
    {
        fuel += diff;
        iconsUI.UpdateIcons();
    }
     public int GetDayNumber()
    {
        return dayNumber;
    }
}
