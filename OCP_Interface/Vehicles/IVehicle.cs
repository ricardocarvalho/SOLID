namespace OCP_Interface.Vehicles
{
    interface IVehicle
    {
        //Trabalhando com todos o metodos que precisa.
        //Poderia ter outros metodos como configureVehicle
        //Vamos deixar esse tema para ISP
        //A interface é uma das maneiras de garantir que OCP está acontecendo
        void StartVehicle();
    }
}
