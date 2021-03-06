﻿using System;

namespace Net
{
    public enum NetworkMsgId
    {
        /// <summary>
        /// 连接
        /// </summary>
        Connect = 1,
        /// <summary>
        /// 断开连接消息
        /// </summary>
        Disconnect,
        /// <summary>
        /// Ping 测试延迟用
        /// </summary>
        Ping,
        /// <summary>
        /// 创建实例
        /// </summary>
        CreateObject,
        DestroyObject,
        /// <summary>
        /// 同步变量
        /// </summary>
        SyncVar,
        /// <summary>
        /// 同步 List
        /// </summary>
        SyncList,
        /// <summary>
        /// 同步事件 
        /// </summary>
        SyncEvent,
        Rpc,
        Max = 10,
    }
}
