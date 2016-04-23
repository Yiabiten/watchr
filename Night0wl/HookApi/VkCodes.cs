using System.ComponentModel;

namespace Night0wl.HookApi
{
    public static class VkCodeHelper
    {
        public static string GetDescription(this VkCode vkCode)
        {
            var memberInfo = typeof(VkCode).GetMember(vkCode.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute) attrs[0]).Description;
                }
            }
            //If no description attr, return ToString
            return vkCode.ToString();
        }
    }

    public enum VkCode
    {
        // The bitmask to extract modifiers from a key value.
        [Description("")] Modifiers = -65536,
        // No key pressed.
        [Description("")] None = 0,
        // The left mouse button.
        [Description("[LButton]")] LButton = 1,
        // The right mouse button.
        [Description("[RButton]")] RButton = 2,
        // The CANCEL key.
        [Description("[Cancel]")] Cancel = 3,
        // The middle mouse button (three-button mouse).
        [Description("[MButton]")] MButton = 4,
        // The first x mouse button (five-button mouse).
        [Description("[XButton1]")] XButton1 = 5,
        // The second x mouse button (five-button mouse).
        [Description("[XButton2]")] XButton2 = 6,
        // The BACKSPACE key.
        [Description("[Back]")] Back = 8,
        // The TAB key.
        [Description("[Tab]")] Tab = 9,
        // The LINEFEED key.
        [Description("[LineFeed]")] LineFeed = 10,
        // The CLEAR key.
        [Description("[Clear]")] Clear = 12,
        // The ENTER key.
        [Description("[Enter]")] Enter = 13,
        // The SHIFT key.
        [Description("[Shift]")] ShiftKey = 16,
        // The CTRL key.
        [Description("[Ctrl]")] ControlKey = 17,
        // The ALT key.
        [Description("[Menu]")] Menu = 18,
        // The PAUSE key.
        [Description("[Pause]")] Pause = 19,
        // The CAPS LOCK key.
        [Description("[CapsLock]")] CapsLock = 20,
        // The IME Kana mode key.
        [Description("[(Hanguel|Kana|Hangul)Mode]")] KanaMode = 21,
        // The IME Junja mode key.
        [Description("[JunjaMode]")] JunjaMode = 23,
        // The IME final mode key.
        [Description("[FinalMode]")] FinalMode = 24,
        // The IME Kanji mode key.
        [Description("[(Kanji|Hanja)Mode]")] KanjiMode = 25,
        // The ESC key.
        [Description("[Esc]")] Escape = 27,
        // The IME convert key.
        [Description("[IMEConvert]")] IMEConvert = 28,
        // The IME nonconvert key.
        [Description("[IMENonconvert]")] IMENonconvert = 29,
        // The IME accept key, replaces System.Windows.Forms.Keys.IMEAceept.
        [Description("[IMEAccept]")] IMEAccept = 30,
        // The IME mode change key.
        [Description("[IMEModeChange]")] IMEModeChange = 31,
        // The SPACEBAR key.
        [Description(" ")] Space = 32,
        // The PAGE UP key.
        [Description("[PgUp]")] PageUp = 33,
        // The PAGE DOWN key.
        [Description("[PgDown]")] PageDown = 34,
        // The END key.
        [Description("[End]")] End = 35,
        // The HOME key.
        [Description("[Home]")] Home = 36,
        // The LEFT ARROW key.
        [Description("[Left]")] Left = 37,
        // The UP ARROW key.
        [Description("[Up]")] Up = 38,
        // The RIGHT ARROW key.
        [Description("[Right]")] Right = 39,
        // The DOWN ARROW key.
        [Description("[Down]")] Down = 40,
        // The SELECT key.
        [Description("[Select]")] Select = 41,
        // The PRINT key.
        [Description("[Print]")] Print = 42,
        // The EXECUTE key.
        [Description("[Execute]")] Execute = 43,
        // The PRINT SCREEN key.
        [Description("[PrintScreen]")] PrintScreen = 44,
        // The INS key.
        [Description("[Insert]")] Insert = 45,
        // The DEL key.
        [Description("[Del]")] Delete = 46,
        // The HELP key.
        [Description("[Help]")] Help = 47,
        // The 0 key.
        [Description("[D0]")] D0 = 48,
        // The 1 key.
        [Description("[D1]")] D1 = 49,
        // The 2 key.
        [Description("[D2]")] D2 = 50,
        // The 3 key.
        [Description("[D3]")] D3 = 51,
        // The 4 key.
        [Description("[D4]")] D4 = 52,
        // The 5 key.
        [Description("[D5]")] D5 = 53,
        // The 6 key.
        [Description("[D6]")] D6 = 54,
        // The 7 key.
        [Description("[D7]")] D7 = 55,
        // The 8 key.
        [Description("[D8]")] D8 = 56,
        // The 9 key.
        [Description("[D9]")] D9 = 57,
        // The A key.
        [Description("A")] A = 65,
        // The B key.
        [Description("B")] B = 66,
        // The C key.
        [Description("C")] C = 67,
        // The D key.
        [Description("D")] D = 68,
        // The E key.
        [Description("E")] E = 69,
        // The F key.
        [Description("F")] F = 70,
        // The G key.
        [Description("G")] G = 71,
        // The H key.
        [Description("H")] H = 72,
        // The I key.
        [Description("I")] I = 73,
        // The J key.
        [Description("J")] J = 74,
        // The K key.
        [Description("K")] K = 75,
        // The L key.
        [Description("L")] L = 76,
        // The M key.
        [Description("M")] M = 77,
        // The N key.
        [Description("N")] N = 78,
        // The O key.
        [Description("O")] O = 79,
        // The P key.
        [Description("P")] P = 80,
        // The Q key.
        [Description("Q")] Q = 81,
        // The R key.
        [Description("R")] R = 82,
        // The S key.
        [Description("S")] S = 83,
        // The T key.
        [Description("T")] T = 84,
        // The U key.
        [Description("U")] U = 85,
        // The V key.
        [Description("V")] V = 86,
        // The W key.
        [Description("W")] W = 87,
        // The X key.
        [Description("X")] X = 88,
        // The Y key.
        [Description("Y")] Y = 89,
        // The Z key.
        [Description("Z")] Z = 90,
        // The left Windows logo key (Microsoft Natural Keyboard).
        [Description("[LWin]")] LWin = 91,
        // The right Windows logo key (Microsoft Natural Keyboard).
        [Description("[RWin]")] RWin = 92,
        // The application key (Microsoft Natural Keyboard).
        [Description("[Apps]")] Apps = 93,
        // The computer sleep key.
        [Description("[Sleep]")] Sleep = 95,
        // The 0 key on the numeric keypad.
        [Description("0")] NumPad0 = 96,
        // The 1 key on the numeric keypad.
        [Description("1")] NumPad1 = 97,
        // The 2 key on the numeric keypad.
        [Description("2")] NumPad2 = 98,
        // The 3 key on the numeric keypad.
        [Description("3")] NumPad3 = 99,
        // The 4 key on the numeric keypad.
        [Description("4")] NumPad4 = 100,
        // The 5 key on the numeric keypad.
        [Description("5")] NumPad5 = 101,
        // The 6 key on the numeric keypad.
        [Description("6")] NumPad6 = 102,
        // The 7 key on the numeric keypad.
        [Description("7")] NumPad7 = 103,
        // The 8 key on the numeric keypad.
        [Description("8")] NumPad8 = 104,
        // The 9 key on the numeric keypad.
        [Description("9")] NumPad9 = 105,
        // The multiply key.
        [Description("*")] Multiply = 106,
        // The add key.
        [Description("+")] Add = 107,
        // The separator key.
        [Description("[Separator]")] Separator = 108,
        // The subtract key.
        [Description("-")] Subtract = 109,
        // The decimal key.
        [Description("[Decimal]")] Decimal = 110,
        // The divide key.
        [Description("/")] Divide = 111,
        // The F1 key.
        [Description("[F1]")] F1 = 112,
        // The F2 key.
        [Description("[F2]")] F2 = 113,
        // The F3 key.
        [Description("[F3]")] F3 = 114,
        // The F4 key.
        [Description("[F4]")] F4 = 115,
        // The F5 key.
        [Description("[F5]")] F5 = 116,
        // The F6 key.
        [Description("[F6]")] F6 = 117,
        // The F7 key.
        [Description("[F7]")] F7 = 118,
        // The F8 key.
        [Description("[F8]")] F8 = 119,
        // The F9 key.
        [Description("[F9]")] F9 = 120,
        // The F10 key.
        [Description("[F10]")] F10 = 121,
        // The F11 key.
        [Description("[F11]")] F11 = 122,
        // The F12 key.
        [Description("[F12]")] F12 = 123,
        // The F13 key.
        [Description("[F13]")] F13 = 124,
        // The F14 key.
        [Description("[F14]")] F14 = 125,
        // The F15 key.
        [Description("[F15]")] F15 = 126,
        // The F16 key.
        [Description("[F16]")] F16 = 127,
        // The F17 key.
        [Description("[F17]")] F17 = 128,
        // The F18 key.
        [Description("[F18]")] F18 = 129,
        // The F19 key.
        [Description("[F19]")] F19 = 130,
        // The F20 key.
        [Description("[F20]")] F20 = 131,
        // The F21 key.
        [Description("[F21]")] F21 = 132,
        // The F22 key.
        [Description("[F22]")] F22 = 133,
        // The F23 key.
        [Description("[F23]")] F23 = 134,
        // The F24 key.
        [Description("[F24]")] F24 = 135,
        // The NUM LOCK key.
        [Description("[NumLock]")] NumLock = 144,
        // The SCROLL LOCK key.
        [Description("[Scroll]")] Scroll = 145,
        // The left SHIFT key.
        [Description("[LShift]")] LShiftKey = 160,
        // The right SHIFT key.
        [Description("[RShift]")] RShiftKey = 161,
        // The left CTRL key.
        [Description("[LCtrl]")] LControlKey = 162,
        // The right CTRL key.
        [Description("[RCtrl]")] RControlKey = 163,
        // The left ALT key.
        [Description("[LMenu]")] LMenu = 164,
        // The right ALT key.
        [Description("[RMenu]")] RMenu = 165,
        // The browser back key (Windows 2000 or later).
        [Description("[BrowserBack]")] BrowserBack = 166,
        // The browser forward key (Windows 2000 or later).
        [Description("[BrowserForward]")] BrowserForward = 167,
        // The browser refresh key (Windows 2000 or later).
        [Description("[BrowserRefresh]")] BrowserRefresh = 168,
        // The browser stop key (Windows 2000 or later).
        [Description("[BrowserStop]")] BrowserStop = 169,
        // The browser search key (Windows 2000 or later).
        [Description("[BrowserSearch]")] BrowserSearch = 170,
        // The browser favorites key (Windows 2000 or later).
        [Description("[BrowserFavorites]")] BrowserFavorites = 171,
        // The browser home key (Windows 2000 or later).
        [Description("[BrowserHome]")] BrowserHome = 172,
        // The volume mute key (Windows 2000 or later).
        [Description("[VolumeMute]")] VolumeMute = 173,
        // The volume down key (Windows 2000 or later).
        [Description("[VolumeDown]")] VolumeDown = 174,
        // The volume up key (Windows 2000 or later).
        [Description("[VolumeUp]")] VolumeUp = 175,
        // The media next track key (Windows 2000 or later).
        [Description("[MediaNextTrack]")] MediaNextTrack = 176,
        // The media previous track key (Windows 2000 or later).
        [Description("[MediaPreviousTrack]")] MediaPreviousTrack = 177,
        // The media Stop key (Windows 2000 or later).
        [Description("[MediaStop]")] MediaStop = 178,
        // The media play pause key (Windows 2000 or later).
        [Description("[MediaPlayPause]")] MediaPlayPause = 179,
        // The launch mail key (Windows 2000 or later).
        [Description("[LaunchMail]")] LaunchMail = 180,
        // The select media key (Windows 2000 or later).
        [Description("[SelectMedia]")] SelectMedia = 181,
        // The start application one key (Windows 2000 or later).
        [Description("[LaunchApplication1]")] LaunchApplication1 = 182,
        // The start application two key (Windows 2000 or later).
        [Description("[LaunchApplication2]")] LaunchApplication2 = 183,
        // The OEM 1 key.
        [Description("[Oem1]")] Oem1 = 186,
        // The OEM Semicolon key on a US standard keyboard (Windows 2000 or later).
        [Description("[OemSemicolon]")] OemSemicolon = 186,
        // The OEM plus key on any country/region keyboard (Windows 2000 or later).
        [Description("[Oemplus]")] Oemplus = 187,
        // The OEM comma key on any country/region keyboard (Windows 2000 or later).
        [Description("[Oemcomma]")] Oemcomma = 188,
        // The OEM minus key on any country/region keyboard (Windows 2000 or later).
        [Description("[OemMinus]")] OemMinus = 189,
        // The OEM period key on any country/region keyboard (Windows 2000 or later).
        [Description("[OemPeriod]")] OemPeriod = 190,
        // The OEM question mark key on a US standard keyboard (Windows 2000 or later).
        [Description("[OemQuestion]")] OemQuestion = 191,
        // The OEM 2 key.
        [Description("[Oem2]")] Oem2 = 191,
        // The OEM tilde key on a US standard keyboard (Windows 2000 or later).
        [Description("[Oemtilde]")] Oemtilde = 192,
        // The OEM 3 key.
        [Description("[Oem3]")] Oem3 = 192,
        // The OEM 4 key.
        [Description("[Oem4]")] Oem4 = 219,
        // The OEM open bracket key on a US standard keyboard (Windows 2000 or later).
        [Description("[OemOpenBrackets]")] OemOpenBrackets = 219,
        // The OEM pipe key on a US standard keyboard (Windows 2000 or later).
        [Description("[OemPipe]")] OemPipe = 220,
        // The OEM 5 key.
        [Description("[Oem5]")] Oem5 = 220,
        // The OEM 6 key.
        [Description("[Oem6]")] Oem6 = 221,
        // The OEM close bracket key on a US standard keyboard (Windows 2000 or later).
        [Description("[OemCloseBrackets]")] OemCloseBrackets = 221,
        // The OEM 7 key.
        [Description("[Oem7]")] Oem7 = 222,
        // The OEM singled/double quote key on a US standard keyboard (Windows 2000
        // or later).
        [Description("[OemQuotes]")] OemQuotes = 222,
        // The OEM 8 key.
        [Description("[Oem8]")] Oem8 = 223,
        // The OEM 102 key.
        [Description("[Oem102]")] Oem102 = 226,
        // The OEM angle bracket or backslash key on the RT 102 key keyboard (Windows
        // 2000 or later).
        [Description("[OemBackslash]")] OemBackslash = 226,
        // The PROCESS KEY key.
        [Description("[Process]")] ProcessKey = 229,
        // Used to pass Unicode characters as if they were keystrokes. The Packet key
        // value is the low word of a 32-bit virtual-key value used for non-keyboard
        // input methods.
        [Description("[Packet]")] Packet = 231,
        // The ATTN key.
        [Description("[Attn]")] Attn = 246,
        // The CRSEL key.
        [Description("[Crsel]")] Crsel = 247,
        // The EXSEL key.
        [Description("[Exsel]")] Exsel = 248,
        // The ERASE EOF key.
        [Description("[EraseEof]")] EraseEof = 249,
        // The PLAY key.
        [Description("[Play]")] Play = 250,
        // The ZOOM key.
        [Description("[Zoom]")] Zoom = 251,
        // A constant reserved for future use.
        [Description("[NoName]")] NoName = 252,
        // The PA1 key.
        [Description("[Pa1]")] Pa1 = 253,
        // The CLEAR key.
        [Description("[OemClear]")] OemClear = 254,
        // The bitmask to extract a key code from a key value.
        [Description("[KeyCode]")] KeyCode = 65535,
        // The SHIFT modifier key.
        [Description("[mShift]")] Shift = 65536,
        // The CTRL modifier key.
        [Description("[mCtrl]")] Control = 131072,
        // The ALT modifier key.
        [Description("[mAlt]")] Alt = 262144
    }
}