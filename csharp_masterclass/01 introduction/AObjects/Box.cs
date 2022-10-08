using System;

namespace AObjects
{
    class Box
    {
        // I'll create a first vars
        private float height;
        private float width;
        private float depth;
        private float volumen;
        private string box_name;

        // Basic constructor
        public Box(float height, float width, float depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.volumen = this.set_volumen();
        }

        private float set_volumen()
        {
            return this.height * this.width * this.depth;
        }

        public float get_volumen()
        {
            return this.volumen;
        }

        // Auto implemented property
        public string BoxName
        {
            get
            {
                return this.box_name;
            }
            set
            {
                this.box_name = value;
            }
        }
    }
}
