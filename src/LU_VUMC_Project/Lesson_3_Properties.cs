using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LU_VUMC_Project
{
    public class Lesson_3_Properties
    {
        public Lesson_3_Properties(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }
        }

        public bool IsMale { get; set; }
        public double Money { get; set; }
        public char Initial { get; set; }

        public string GetGreeting()
        {
            return $"Hello my name is {Name} and I am {Age} years old.";
        }

        //================================================================================

        public string brand { get; set; }
        public string modelPhone { get; set; }
        public int sizeX { get; set; }
        public int sizeY { get; set; }
        public string funcCall { get; set; }
        public string funcSMS { get; set; }

        //================================================================================

        public string modelCar { get; set; }

        //================================================================================

        private string _itemName;
        public string itemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                if(_itemName == null)
                {
                    _itemName = value;
                }
            }
        }

        private string _itemSizeX;
        public string itemSizeX
        {
            get
            {
                return _itemSizeX;
            }
            set
            {
                if (_itemSizeX == null)
                {
                    _itemSizeX = value;
                }
            }
        }

        private string _itemSizeY;
        public string itemSizeY
        {
            get
            {
                return _itemSizeY;
            }
            set
            {
                if (_itemSizeY == null)
                {
                    _itemSizeY = value;
                }
            }
        }

        private string _itemSizeZ;
        public string itemSizeZ
        {
            get
            {
                return _itemSizeZ;
            }
            set
            {
                if (_itemSizeZ == null)
                {
                    _itemSizeZ = value;
                }
            }
        }

        private string _itemWeight;
        public string itemWeight
        {
            get
            {
                return _itemWeight;
            }
            set
            {
                if (_itemWeight == null)
                {
                    _itemWeight = value;
                }
            }
        }







    }
}
