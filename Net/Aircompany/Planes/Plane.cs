﻿using System.Collections.Generic;
using System.Dynamic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model { get; set; }
        public int maxSpeed { get; set; }
        public int maxFlightDistance { get; set; }
        public int maxLoadCapacity { get; set; }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            this.Model = model;
            this.maxSpeed = maxSpeed;
            this.maxFlightDistance = maxFlightDistance;
            this.maxLoadCapacity = maxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + maxSpeed +
                ", maxFlightDistance=" + maxFlightDistance +
                ", maxLoadCapacity=" + maxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   maxSpeed == plane.maxSpeed &&
                   maxFlightDistance == plane.maxFlightDistance &&
                   maxLoadCapacity == plane.maxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + maxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + maxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + maxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
