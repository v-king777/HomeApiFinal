﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Запрос для обновления свойств подключенных комнат
    /// </summary>
    public class EditRoomRequest
    {
        public int NewArea { get; set; }

        public bool NewGasConnected { get; set; }

        public int NewVoltage { get; set; }
    }
}
