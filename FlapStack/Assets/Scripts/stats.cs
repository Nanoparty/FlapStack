using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class stats 
{


    private static int max, coins;
    private static bool donut, egg;

    public static int Max
    {
        get
        {
            return max;
        }
        set
        {
            max = value;
        }
    }

    public static int Coins
    {
        get
        {
            return coins;
        }
        set
        {
            coins = value;
        }
    }

    public static bool Donut
    {
        get
        {
            return donut;
        }
        set
        {
            donut = value;
        }
    }

    public static bool Egg
    {
        get
        {
            return egg;
        }
        set
        {
            egg = value;
        }
    }
}
