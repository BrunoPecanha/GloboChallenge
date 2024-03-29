﻿using Pecanha.Domain.Enum;
using System;

namespace Pecanha.Domain.Commands {

    /// <summary>
    /// Command para alterar estado das cenas   
    /// </summary>
    public class SceneUpdateCommand {
        public int Id { get; set; }
        public StateEnum NextState { get; set; }
        public DateTime OperationHour { get; set; }
    }
}
