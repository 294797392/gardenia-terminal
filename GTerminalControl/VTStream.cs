﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTerminalControl
{
    /// <summary>
    /// 定义了控制终端数据流的接口
    /// </summary>
    public interface IVTStream
    {
        event Action<object, VTStreamState> StatusChanged;

        /// <summary>
        /// 从数据流中读取一段数据
        /// </summary>
        /// <param name="size">要读取的数据大小</param>
        /// <returns></returns>
        byte[] Read(int size);

        /// <summary>
        /// 从数据流中读取一个字节的数据
        /// </summary>
        /// <returns></returns>
        byte Read();

        /// <summary>
        /// 想数据流里写入一个字节的数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Write(byte data);

        /// <summary>
        /// 想数据流里写入一段数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        bool Write(byte[] data);

        /// <summary>
        /// EOF为True时，VideoTerminal会停止解析
        /// </summary>
        bool EOF { get; }
    }
}