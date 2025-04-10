namespace Animal_Sound
{
    public abstract class Animal
    {
        public string Type { get; }
        public string Sound { get; }

        protected Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        public string GetSoundMessage() => $"{Type} face sunet: {Sound}";
    }
}