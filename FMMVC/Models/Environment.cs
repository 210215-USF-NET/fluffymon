using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMMVC.Models
{
    public static class Environment
    {

        public static String[,] map = new string[6, 5]{
            {"Wall", "Wall", "Wall", "Wall", "Wall"},
            {"Wall","Graveyard","Hills","Hills","Wall"},
            {"Wall","Bendyroad","Library","Kitchen","Wall"},
           {"Wall","Road","School","Hills","Wall"},
            {"Wall","Hills","Road","Hills","Wall"},
           {"Wall", "Wall", "Wall", "Wall", "Wall"} };


        public static int x = 2;
        public static int y = 4;

        public static string GetLocation()
        {
            return map[x, y];
        }

        public static string GetLocation(int tx,int ty)
        {
            return map[tx, ty];
        }
        public static void north(){
            int tempy = x;
            tempy -= 1;
            if (tempy >= 0)
            {
                x = tempy;
            }
            }
        public static void south()
        {
            int tempy = x;
            tempy += 1;
            if (tempy <= 5)
            {
                x = tempy;
            }
        }


        public static void east()
        {
            int tempx = y;
            tempx += 1;
            if (tempx <= 4)
            {
                y = tempx;
            }
        }

        public static void west()
        {
            int tempx = y;
            tempx -= 1;
            if (tempx >= 0)
            {
                y = tempx;
            }
        }

        public static string Getnorth()
        {
            int tempy = x;
            tempy -= 1;
            if (tempy <= 0)
            {
               tempy=0;
            }
            return GetLocation(tempy, y);
        }
        public static string Getsouth()
        {
            int tempy = x;
            tempy += 1;
            if (tempy >= 5)
            {
                tempy = 5;
            }
            return GetLocation(tempy,y);
        }


        public static string Geteast()
        {
            int tempy = y;
            tempy += 1;
            if (tempy >= 4)
            {
                tempy=4;
            }
            return GetLocation(x,tempy);
        }

        public static string Getwest()
        {
            int tempy = y;
            tempy -= 1;
            if (tempy <= 0)
            {
                tempy = 0;
            }
            return GetLocation(x,tempy);
        }


    }
}
