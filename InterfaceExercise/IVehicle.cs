namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        string EngineSize { get; set; }
        void Drive();
    }
}