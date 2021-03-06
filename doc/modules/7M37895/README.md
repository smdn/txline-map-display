# 森尾電機 7M37895
停車駅・進行方向表示LEDモジュール(5駅分)

![基盤表面](https://github.com/smdn/txline-map-display/blob/images/doc/modules/7M37895/board-front.jpg)
![基盤裏面](https://github.com/smdn/txline-map-display/blob/images/doc/modules/7M37895/board-back.jpg)

`LED1〜16`はすべて🟥赤🟩緑二色LED。　12V、アノードコモン回路。

進行方向表示(`LED1,2,4,5,7,8,10,11,13,14`)は🟩緑色のみ結線されているため🟥赤色を点灯させることはできない。

また、`LED16`は🟥赤🟩緑二色とも点灯させられるが、パネルで隠される。　`LED16`本来の用途は不明(列車種別表示用?)。

関連:[7M37896/8M49450](../7M37896_8M49450/README.md)

## 接続

|コネクタ|接続モジュール|
|-------:|:---------|
|`CN1`|[6M15040](../6M15040/README.md)|

### コネクタ`CN1`
|端子|接続LED|
|---:|:------|
|1|(+12V)|
|2|^|
|3|^|
|4|^|
|5|`LED1` 🟩緑|
|6|`LED2` 🟩緑|
|7|`LED3` 🟩緑|
|8|`LED3` 🟥赤|
|9|`LED4` 🟩緑|
|10|`LED5` 🟩緑|
|11|`LED6` 🟥赤|
|12|`LED6` 🟩緑|
|13|`LED7` 🟩緑|
|14|`LED8` 🟩緑|
|15|`LED9` 🟥赤|
|16|`LED9` 🟩緑|
|17|`LED10` 🟩緑|
|18|`LED11` 🟩緑|
|19|`LED12` 🟥赤|
|20|`LED12` 🟩緑|
|21|`LED13` 🟩緑|
|22|`LED14` 🟩緑|
|23|`LED15` 🟥赤|
|24|`LED15` 🟩緑|
|25|`LED16` 🟥赤|
|26|`LED16` 🟩緑|

### 抵抗
- 🟩緑 200Ω 1/4W
- 🟥赤 240Ω 1/4W