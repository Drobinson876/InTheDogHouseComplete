using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9_Houses
{

    public class MyDog
    {
        private string name;
        private int dogNo;
        private int breedNo;
        private string colour;
        private string DOB;
        private char gender;
        private int customerNo;
        public MyDog()
        {
            this.Name = "";
            this.DogNo = 0;
            this.breedNo = 0;
            this.colour = "";
            this.DOB = "";
            this.gender = 'x';
            this.customerNo = 0;
        }

        public MyDog(string name, int dogNo, int breedNo, string colour, string DOB, char gender, int customerNo)

        {

            this.Name = name;

            this.DogNo = dogNo;

            this.breedNo = breedNo;

            this.colour = colour;

            this.DOB = DOB;

            this.gender = gender;

            this.customerNo = customerNo;

        }

        public string Name

        {
            get => name;

            set => name = value;

        }

        public int DogNo

        {
            get => dogNo;

            set => dogNo = value;

        }

        public int BreedNo

        {
            get => breedNo;

            set => breedNo = value;

        }

        public string Colour

        {
            get => colour;

            set => colour = value;

        }

        public string DogDOB

        {
            get => DOB;

            set => DOB = value;

        }

        public char Gender

        {
            get => gender;

            set => gender = value;

        }

        public int CustomerNo

        {
            get => customerNo;

            set => customerNo = value;

        }

    }

}
