using System.Collections.Generic;
using UnityEngine;

public class Worldstate : MonoBehaviour
{
    public object Instance { get; private set; }

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
    private string[] peopleInCar;


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
    }

    public void SetLocation(string newLocation)
    {
        locationHistory[numPlacesVisited] = newLocation; // adding new visit to location list
        numPlacesVisited++; // incrementing number of visits
        currentLocation = newLocation; 
    }

    public string GetLocation()
    {
        return currentLocation;
    }
}
