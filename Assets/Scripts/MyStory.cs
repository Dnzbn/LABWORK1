using UnityEngine;

// GAD1003 - Chapter 3 Lab: My Story
// Theme: a lighthouse keeper's night during a storm.

public class MyStory : MonoBehaviour
{
    // ----- Character -----
    [SerializeField] string keeperName = "Deniz";
    [SerializeField] char rank = 'B';
    [SerializeField] int health = 100;
    [SerializeField] float lampOil = 20f;       
    [SerializeField] int coins = 40;
    [SerializeField] int fishCaught = 3;

    // ----- Choices -----
    [SerializeField] int candlesToBuy = 3;       // keep at 1 or more
    [SerializeField] float hoursToSleep = 2.5f;
    [SerializeField] int shipsToGuide = 4;
    [SerializeField] int crewToShareWith = 3;    // must be 1 or more 

    void Start()
    {
        print(keeperName + " (rank " + rank + ") climbs the old lighthouse as a storm rolls in.");

        // Event 1: buying candles costs money
        coins -= candlesToBuy * 5;
        print(keeperName + " buys " + candlesToBuy + " candles at 5 coins each. Coins: " + coins);

        // Event 2: the lamp burns oil while the keeper sleeps
        lampOil -= hoursToSleep * 2f;
        print(keeperName + " naps for " + hoursToSleep + " hours while the lamp burns. Lamp oil: " + lampOil + " L");

        // Event 3: an accident on the stairs
        health -= 15;
        print("Slipped on the wet spiral stairs! Health: " + health);

        // Event 4: the wind blows out a candle
        candlesToBuy--;
        print("A gust of wind blows out a candle. Candles left: " + candlesToBuy);

        // Event 5: ships pay for safe guidance
        coins += shipsToGuide * 12;
        print(shipsToGuide + " ships reach the harbour safely and pay 12 coins each. Coins: " + coins);

        // Event 6: a grateful fisherman doubles the catch
        fishCaught *= 2;
        print("A grateful fisherman doubles " + keeperName + "'s catch. Fish: " + fishCaught);

        // Event 7: hot tea helps recovery
        health += 10;
        print(keeperName + " drinks hot tea by the lamp. Health: " + health);

        // Event 8: a fish lands on the balcony
        fishCaught++;
        print("A wave throws a fish onto the balcony! Fish: " + fishCaught);

        // Division: share the coins with the crew
        print("The coins are shared among " + crewToShareWith + " crew members: "
              + (coins / crewToShareWith) + " each, " + (coins % crewToShareWith) + " left over.");

        print($"Morning comes. {keeperName} has {health} health, {lampOil} L of oil and {fishCaught} fish for breakfast.");
    }
}