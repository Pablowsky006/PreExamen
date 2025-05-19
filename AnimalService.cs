using System.Collections.Generic;

namespace PreExamen.Models
{
    public class AnimalService
    {
        public List<Animal> Animales { get; } = new();

        public void AgregarAnimal(Animal animal)
        {
            Animales.Add(animal);
        }
    }
}
