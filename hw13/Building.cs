﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
    class Building
    {
        static private uint number;
        private uint height;
        private byte floors;
        private uint apartments;
        private uint entrance;

        public uint Height { get => height; set => height = value; }
        public byte Floors { get => floors; set => floors = value; }
        public uint Apartments { get => apartments; set => apartments = value; }
        public uint Entrance { get => entrance; set => entrance = value; }

        public Building(uint height, byte floors, uint apartments, uint entrance)
        {
            this.height = height;
            this.floors = floors;
            if (apartments < floors * entrance)
            {
                apartments = floors * entrance;
                Console.WriteLine("Квартир не может быть меньше чем 1 на подъезд и этаж");
            }
            this.apartments = apartments;
            this.entrance = entrance;
            SetNumber();
        }
        public Building()
        {
            SetNumber();
        }

        private void SetNumber()
        {
            number += 1;
        }

        public override string ToString()
        {
            return "Здание номер " + number.ToString() + " Высота=" + Height.ToString() + " Этажей=" + floors.ToString() + " Квартир=" + apartments.ToString();
        }

        public double HeightFloor()
        {
            if (floors != 0)
            {
                return (double)height / floors;
            }
            else
            {
                return -1;
            }

        }

        public uint ApartInEntrance() => apartments / entrance;
        public uint ApartInFloor() => apartments / entrance / floors;
    }
}

