﻿using Proyecto_2.Models;

namespace Proyecto_2.Servicios
{
    public interface IServicioEmpleado
    {
        public Task<List<Empleado>> Get();

        public Task<bool> Crear(Empleado obj_empleado);

        public Task<Empleado> ObtenerEmpleado(int id);

        public Task<bool> Put(int id, Empleado obj_empleado);

        public Task<bool> Delete(int id);
    }
}
