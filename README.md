# 喷涂工艺 SCADA 监控系统

基于 C# WinForms + SunnyUI 的工业喷涂生产线监控上位机，通过西门子 S7 协议与 PLC 通信，实现设备实时监控、数据采集、配方管理和权限控制。

## 项目亮点

- 通过 IoTClient 实现西门子 S7 协议 PLC 通信，支持 BatchRead 批量读取与断线自动重连
- 设计三字典架构（ReadDic / WriteDic / DataDic）管理 PLC 变量的读写分离
- 采用三层架构 + DI 依赖注入，换数据库只需改 DAL 层
- 6 个自定义控件绑定 PLC 变量，通过 Invoke 实现多线程下 UI 实时刷新
- 基于 SqlSugar ORM + SQLite 实现配方管理、报警记录等数据持久化

## PLC 通信设计

核心采用三字典架构管理变量读写：

- **ReadDic**：地址 → 数据类型映射，用于 BatchRead 批量读取
- **WriteDic**：变量名 → 地址映射，用于写入控制指令
- **DataDic**：变量名 → 当前值映射，用于界面实时显示

后台轮询线程通过 `Task.Run()` 持续读取 PLC 数据，自动检测断线并重连。变量配置通过 Excel 文件定义，运行时通过 MiniExcel 加载。

## 系统架构

```
UI层（WinForms/SunnyUI） → BLL层（业务逻辑） → DAL层（SqlSugar ORM） → Model层
```

解决方案包含 5 个子项目：UI、BLL、DAL、Model、Helper，通过 DI 容器自动注册。

## 功能模块

| 模块 | 说明 |
|------|------|
| 设备总控 | 通过 PLC 写入控制设备启停，操作日志记录 |
| 设备监控 | 实时显示设备状态灯、变量值、报警信息，500ms 刷新（3 个工艺段分区） |
| 配方管理 | 产品配方 CRUD，支持 Excel 导入导出，配方参数下载到 PLC |
| 图表管理 | 历史数据折线图（压力、pH、温度等 7 条曲线） |
| 报表管理 | 按日期查询历史数据，支持分页和 Excel 导出 |
| 用户/权限管理 | 基于角色的访问控制（管理员/工程师/操作员/访客） |
| 日志管理 | NLog 日志按日期/级别归档，支持浏览和导出 |
| 参数设置 | PLC 连接参数配置、读取间隔、重连策略、日志清理 |

## 主界面功能

- 状态栏实时显示：产品计数、周期时间、温度、湿度、CPU/内存占用率
- 报警检测：自动识别报警变量，报警时状态栏红色滚动提示
- 自动数据采集：1 秒定时器将需要保存的变量值写入数据库
- 主题/字体/字号切换：支持 SunnyUI 多主题风格、6 种字体、75%-125% 缩放

## 监控工艺段

脱脂 → 粗洗 → 化学转化 → 精洗 → 水分炉 → 固化炉 → 冷却 → 输送系统

## 技术栈

| 类别 | 技术 |
|------|------|
| UI 框架 | SunnyUI 3.7.2 + WinForms |
| PLC 通信 | IoTClient（S7 协议），批量读取 + 断线重连 |
| ORM | SqlSugar Core（SQLite） |
| Excel 读写 | MiniExcel |
| 依赖注入 | Microsoft.Extensions.DependencyInjection |
| 对象映射 | Mapster |
| 日志 | NLog |
| 目标框架 | .NET 10.0 |

## 自定义控件

6 个继承自 SunnyUI 的自定义控件，支持设计时属性配置：

- 设备状态指示灯、变量值显示、报警指示、设备单元控制、计数按钮、参数设置输入

## 运行方式

1. 使用 Visual Studio 2022 打开 `SprayingProcessSystem.slnx`
2. 还原 NuGet 包
3. 编译运行

## 注意事项

- 需连接西门子 S7 系列 PLC（或使用 PLCSIM Advanced 模拟器）
- PLC 变量配置通过 Excel 文件定义，首次运行需在"参数设置"页面配置变量表路径
- SQLite 数据库（`SprayData.db`）首次运行自动创建，需手动在数据库中添加管理员账户才能登录
