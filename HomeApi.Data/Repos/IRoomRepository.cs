﻿using System;
using System.Threading.Tasks;
using HomeApi.Data.Models;
using HomeApi.Data.Queries;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        Task<Room> GetRoomByName(string name);

        Task AddRoom(Room room);

        Task<Room[]> GetRooms();

        Task UpdateRoom(Room room, UpdateRoomQuery query);

        Task DeleteRoom(Room room);

        Task<Room> GetRoomById(Guid id);
    }
}
