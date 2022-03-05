# C# SoftKeyboard

C# 软键盘输入框，功能包括但不限于在工控机触屏上替代普通的 InputBox 。

## 版本一：NumberInputBox

NumberInputBox 是数字键（9键）输入框，只能用于输入正整数或正小数（得到 string 类型，而不是 int 类型）。

|    ![图1](./images/9键.png)    |
| :----------------------------: |
| **图1**：NumberInputBox 的界面 |

推荐的调用方式如下：

```C#
string age = "";
if ( SoftKeyBoard.NumberInputBox.Show("请输入年龄", ref age) ) {
    // 用户点了“完成”，则执行这里
    Console.WriteLine("你的年龄是:" + age);
} else {
    // 用户点了“取消”，则执行这里
}
```



## 版本二：TextInputBox

TextInputBox 是全键（26键）输入框，可以用于输入大小写26个字母、数字、部分特殊符号。

| ![图2](./images/全键-字母.png) |
| :----------------------------: |
|  **图2**：TextInputBox 的界面  |

|              ![图3](./images/全键-数字.png)               |
| :-------------------------------------------------------: |
| **图3**：TextInputBox 的界面（切换到了数字/符号输入模式） |

推荐的调用方式与 NumberInputBox 相同。
