namespace Factory.Src
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public bool IsPrepared { get; set; }
        public bool IsBaked { get; set; }
        public bool IsCut { get; set; }
        public bool IsBoxed { get; set; }

        public virtual void Prepare() => IsPrepared = true;

        public virtual void Bake() => IsBaked = true;

        public virtual void Cut() => IsCut = true;

        public virtual void Box() => IsBoxed = true;
    }
}