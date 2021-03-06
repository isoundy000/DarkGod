/****************************************************
    文件：Constants.cs
	作者：CaptainYun
    日期：2019/5/12 22:30:0
	功能：常量配置
*****************************************************/

using UnityEngine;

/// <summary>
/// 文字颜色
/// </summary>
public enum TxtColor {
    Red,
    Green,
    Blue,
    Yellow
}

/// <summary>
/// 伤害类型
/// </summary>
public enum DamageType {
    None,
    AD = 1,
    AP = 2
}

/// <summary>
/// 实体类型
/// </summary>
public enum EntityType {
    None,
    Player,
    Monster
}

/// <summary>
/// 实体状态
/// </summary>
public enum EntityState {
    None,
    BatiState, // 霸体状态：不可控制，可受伤害，不会有受击效果，释放技能时根据 isBreak 判断霸体
    // TODO
}

/// <summary>
/// 怪物类型
/// </summary>
public enum MonsterType {
    None,
    Normal = 1,
    Boss = 2
}

public class Constants {

    #region 颜色

    private const string ColorRed = "<color=#FF0000FF>";
    private const string ColorGreen = "<color=#00FF00FF>";
    private const string ColorBlue = "<color=#00B4FFFF>";
    private const string ColorYellow = "<color=#FFFF00FF>";
    private const string ColorEnd = "</color>";

    /// <summary>
    /// 设置颜色
    /// </summary>
    public static string Color(string str, TxtColor c) {
        string result = "";
        switch (c) {
            case TxtColor.Red:
                result = ColorRed + str + ColorEnd;
                break;
            case TxtColor.Green:
                result = ColorGreen + str + ColorEnd;
                break;
            case TxtColor.Blue:
                result = ColorBlue + str + ColorEnd;
                break;
            case TxtColor.Yellow:
                result = ColorYellow + str + ColorEnd;
                break;
        }
        return result;
    }
    #endregion

    // --------------- 场景名称/ID ----------------
    public const string SceneLogin = "SceneLogin";
    public const int MainCityMapID = 10000;
    //public const string SceneMainCity = "SceneMainCity";

    // --------------- BGM ----------------
    public const string BGLogin = "bgLogin"; // 登录场景的背景音乐
    public const string BGMainCity = "bgMainCity"; // 主城背景音乐
    public const string BGHuangYe = "bgHuangYe"; // 战斗副本

    // --------------- 音效 ----------------
    // 常规 UI 点击音效
    public const string UILoginBtn = "uiLoginBtn";  // 登录游戏音效
    public const string UIClickBtn = "uiClickBtn"; // 按钮点击音效
    public const string UIExtenBtn = "uiExtenBtn"; // 主界面菜单
    public const string UIOpenPage = "uiOpenPage"; // 打开窗口
    public const string AssassinHit = "assassin_Hit"; // 角色受击
    public const string FBItemEnter = "fbitem";
    public const string FBLose = "fblose";
    public const string FBLogoEnter = "fbwin";

    // --------------- 移动速度 ----------------
    public const int PlayerMoveSpeed = 8; // 角色
    public const int MonsterMoveSpeed = 3; // 怪物

    // --------------- 角色 ----------------
    // 角色运动平滑加速度
    public const float AccelerSpeed = 5;
    // 混合参数
    public const int BlendIdle = 0;
    public const int BlendMove = 1;
    // Action 触发参数
    public const int ActionDefault = -1;
    public const int ActionBorn = 0;
    public const int ActionDie = 100;
    public const int ActionHit = 101;
    // 死亡动画的长度
    public const int DieAniLength = 3000;

    // --------------- 其他 ----------------
    // 屏幕标准宽高
    public const int ScreenStandardWidth = 1334;
    public const int ScreenStandardHeight = 750;

    // 摇杆点标准距离
    public const int ScreenOPDis = 90;

    // 自动引导的 NPC ID
    public const int NPCWiseMan = 0;
    public const int NPCGeneral = 1;
    public const int NPCArtisan = 2;
    public const int NPCTrader = 3;

    // 血条渐变
    public static float AccelerHPSpeed = 0.3F;

    // 普攻连招有效间隔
    public static int ComboSpace = 500;
}