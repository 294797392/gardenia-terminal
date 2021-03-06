﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kagura.Terminal.Controls
{
    public class VTPsrDef
    {
        public const byte CASE_GROUND_STATE = 0;
        public const byte CASE_IGNORE = 1;

        /// <summary>
        /// 响铃
        /// BEL is used when there is a need to call for attention; it may control alarm or attention devices. 
        /// </summary>
        public const byte CASE_BELL = 2;

        /// <summary>
        /// 退格
        /// BS causes the active data position to be moved one character position in the data component in the 
        /// direction opposite to that of the implicit movement.
        /// The direction of the implicit movement depends on the parameter value of SELECT IMPLICIT 
        /// MOVEMENT DIRECTION(SIMD). 
        /// </summary>
        public const byte CASE_BS = 3;

        /// <summary>
        /// CarriageReturn
        /// 回车，把光标移动到第一列
        /// </summary>
        public const byte CASE_CR = 4;
        public const byte CASE_ESC = 5;
        public const byte CASE_VMOT = 6;
        public const byte CASE_TAB = 7;
        public const byte CASE_SI = 8;
        public const byte CASE_SO = 9;
        public const byte CASE_SCR_STATE = 10;
        public const byte CASE_SCS0_STATE = 11;
        public const byte CASE_SCS1_STATE = 12;
        public const byte CASE_SCS2_STATE = 13;
        public const byte CASE_SCS3_STATE = 14;
        public const byte CASE_ESC_IGNORE = 15;
        public const byte CASE_ESC_DIGIT = 16;
        public const byte CASE_ESC_SEMI = 17;
        public const byte CASE_DEC_STATE = 18;
        public const byte CASE_ICH = 19;
        public const byte CASE_CUU = 20;
        public const byte CASE_CUD = 21;
        public const byte CASE_CUF = 22;
        public const byte CASE_CUB = 23;
        public const byte CASE_CUP = 24;
        public const byte CASE_ED = 25;
        public const byte CASE_EL = 26;
        public const byte CASE_IL = 27;
        public const byte CASE_DL = 28;
        public const byte CASE_DCH = 29;
        public const byte CASE_DA1 = 30;
        public const byte CASE_TRACK_MOUSE = 31;
        public const byte CASE_TBC = 32;
        public const byte CASE_SET = 33;
        public const byte CASE_RST = 34;
        public const byte CASE_SGR = 35;
        public const byte CASE_CPR = 36;
        public const byte CASE_DECSTBM = 37;
        public const byte CASE_DECREQTPARM = 38;
        public const byte CASE_DECSET = 39;
        public const byte CASE_DECRST = 40;
        public const byte CASE_DECALN = 41;
        public const byte CASE_GSETS = 42;
        public const byte CASE_DECSC = 43;
        public const byte CASE_DECRC = 44;
        public const byte CASE_DECKPAM = 45;
        public const byte CASE_DECKPNM = 46;
        public const byte CASE_IND = 47;
        public const byte CASE_NEL = 48;
        public const byte CASE_HTS = 49;
        public const byte CASE_RI = 50;
        public const byte CASE_SS2 = 51;
        public const byte CASE_SS3 = 52;
        public const byte CASE_CSI_STATE = 53;

        #region ESC子状态
        /// <summary>
        /// Operating System Commands
        /// </summary>
        public const byte CASE_OSC = 54;
        #endregion

        public const byte CASE_RIS = 55;
        public const byte CASE_LS2 = 56;
        public const byte CASE_LS3 = 57;
        public const byte CASE_LS3R = 58;
        public const byte CASE_LS2R = 59;
        public const byte CASE_LS1R = 60;
        public const byte CASE_PRINT = 61;
        public const byte CASE_XTERM_SAVE = 62;
        public const byte CASE_XTERM_RESTORE = 63;
        public const byte CASE_XTERM_TITLE = 64;
        public const byte CASE_DECID = 65;
        public const byte CASE_HP_MEM_LOCK = 66;
        public const byte CASE_HP_MEM_UNLOCK = 67;
        public const byte CASE_HP_BUGGY_LL = 68;
        public const byte CASE_HPA = 69;
        public const byte CASE_VPA = 70;
        public const byte CASE_XTERM_WINOPS = 71;
        public const byte CASE_ECH = 72;
        public const byte CASE_CHT = 73;
        public const byte CASE_CPL = 74;
        public const byte CASE_CNL = 75;
        public const byte CASE_CBT = 76;
        public const byte CASE_SU = 77;
        public const byte CASE_SD = 78;
        public const byte CASE_S7C1T = 79;
        public const byte CASE_S8C1T = 80;
        public const byte CASE_ESC_SP_STATE = 81;
        public const byte CASE_ENQ = 82;
        public const byte CASE_DECSCL = 83;
        public const byte CASE_DECSCA = 84;
        public const byte CASE_DECSED = 85;
        public const byte CASE_DECSEL = 86;
        public const byte CASE_DCS = 87;
        public const byte CASE_PM = 88;
        public const byte CASE_SOS = 89;

        /// <summary>
        /// String Terminator
        /// ST is used as the closing delimiter of a control string opened by APPLICATION PROGRAM COMMAND (APC), DEVICE CONTROL STRING (DCS), OPERATING SYSTEM COMMAND 
        /// (OSC), PRIVACY MESSAGE(PM), or START OF STRING(SOS).
        /// </summary>
        public const byte CASE_ST = 90;
        public const byte CASE_APC = 91;
        public const byte CASE_EPA = 92;
        public const byte CASE_SPA = 93;
        public const byte CASE_CSI_QUOTE_STATE = 94;
        public const byte CASE_DSR = 95;
        public const byte CASE_ANSI_LEVEL_1 = 96;
        public const byte CASE_ANSI_LEVEL_2 = 97;
        public const byte CASE_ANSI_LEVEL_3 = 98;
        public const byte CASE_MC = 99;
        public const byte CASE_DEC2_STATE = 100;
        public const byte CASE_DA2 = 101;
        public const byte CASE_DEC3_STATE = 102;
        public const byte CASE_DECRPTUI = 103;
        public const byte CASE_VT52_CUP = 104;
        public const byte CASE_REP = 105;
        public const byte CASE_CSI_EX_STATE = 106;
        public const byte CASE_DECSTR = 107;
        public const byte CASE_DECDHL = 108;
        public const byte CASE_DECSWL = 109;
        public const byte CASE_DECDWL = 110;
        public const byte CASE_DEC_MC = 111;
        public const byte CASE_ESC_PERCENT = 112;
        public const byte CASE_UTF8 = 113;
        public const byte CASE_CSI_TICK_STATE = 114;
        public const byte CASE_DECELR = 115;
        public const byte CASE_DECRQLP = 116;
        public const byte CASE_DECEFR = 117;
        public const byte CASE_DECSLE = 118;
        public const byte CASE_CSI_IGNORE = 119;
        public const byte CASE_VT52_IGNORE = 120;
        public const byte CASE_VT52_FINISH = 121;
        public const byte CASE_CSI_DOLLAR_STATE = 122;
        public const byte CASE_DECCRA = 123;
        public const byte CASE_DECERA = 124;
        public const byte CASE_DECFRA = 125;
        public const byte CASE_DECSERA = 126;
        public const byte CASE_DECSACE = 127;
        public const byte CASE_DECCARA = 128;
        public const byte CASE_DECRARA = 129;
        public const byte CASE_CSI_STAR_STATE = 130;
        public const byte CASE_SET_MOD_FKEYS = 131;
        public const byte CASE_SET_MOD_FKEYS0 = 132;
        public const byte CASE_HIDE_POINTER = 133;
        public const byte CASE_SCS1A_STATE = 134;
        public const byte CASE_SCS2A_STATE = 135;
        public const byte CASE_SCS3A_STATE = 136;
        public const byte CASE_CSI_SPACE_STATE = 137;
        public const byte CASE_DECSCUSR = 138;
        public const byte CASE_SM_TITLE = 139;
        public const byte CASE_RM_TITLE = 140;
        public const byte CASE_DECSMBV = 141;
        public const byte CASE_DECSWBV = 142;
        public const byte CASE_DECLL = 143;
        public const byte CASE_DECRQM = 144;
        public const byte CASE_RQM = 145;
        public const byte CASE_CSI_DEC_DOLLAR_STATE = 146;
        public const byte CASE_SL = 147;
        public const byte CASE_SR = 148;
        public const byte CASE_DECDC = 149;
        public const byte CASE_DECIC = 150;
        public const byte CASE_DECBI = 151;
        public const byte CASE_DECFI = 152;
        public const byte CASE_DECRQCRA = 153;
        public const byte CASE_HPR = 154;
        public const byte CASE_VPR = 155;
        public const byte CASE_ANSI_SC = 156;
        public const byte CASE_ANSI_RC = 157;
        public const byte CASE_ESC_COLON = 158;
        public const byte CASE_SCS_PERCENT = 159;
        public const byte CASE_GSETS_PERCENT = 160;
        public const byte CASE_GRAPHICS_ATTRIBUTES = 161;




        /// <summary>
        /// 换行
        /// 创建一个新行
        /// </summary>
        public const byte CASE_LF = 162;

        /// <summary>
        /// 垂直制表符
        /// 它的作用是让‘\v’后面的字符从下一行开始输出，且开始的列数为“\v”前一个字符所在列后面一列。
        /// 例如：puts("01\v2345");
        /// 01在第一行，占用两列。2345在第二行，并且2在第三列
        /// 
        /// 8.3.161 VT - LINE TABULATION
        /// </summary>
        public const byte CASE_VT = 163;

        /// <summary>
        /// 换页（‘\f’）       
        /// 换页符的在终端的中的效果相当于*nix中clear命令。
        /// 终端在输出‘\f’之后内容之前，会将整个终端屏幕清空空，然后在输出内容。
        /// 给人的该觉是在clear命令后的输出字符串。 最后我想说明一点，‘\r’‘\t’‘\v’‘\f’也是控制字符，它们会控制字符的输出方式。
        /// 它们在终端输出时会有上面的表现，但如果写入文本文件，一般文本编辑器（vi或记事本）对‘\r’‘\v’‘\f’的显示是没有控制效果的。
        /// 
        /// 8.3.51 FF - FORM FEED
        /// </summary>
        public const byte CASE_FF = 164;
    }
}
