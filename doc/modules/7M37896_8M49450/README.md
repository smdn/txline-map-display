# 森尾電機 7M37896/8M49450
関連:[7M37895](../7M37895/README.md)

## 7M37896
停車駅・進行方向表示LEDモジュール(5駅分)

<!-- ![基盤表面](https://raw.githubusercontent.com/smdn/txline-map-display/images/doc/modules/7M37896_8M49450/7M37896-board-front.jpg) -->
<!-- ![基盤裏面](https://raw.githubusercontent.com/smdn/txline-map-display/images/doc/modules/7M37896_8M49450/7M37896-board-back.jpg) -->

`LED1〜15`はすべて🟥赤🟩緑二色LED。　12V、アノードコモン回路。

進行方向表示(`LED1,2,4,5,7,8,10,11,13,14`)は🟩緑色のみ結線されているため🟥赤色を点灯させることはできない。　[7M37895](../7M37895/README.md)とは異なり、`LED16`はない。

## 8M49450
開閉ドア表示LEDモジュール。　7M37896のサブモジュールとして個別の基盤となっている。

<!-- ![基盤表面](https://raw.githubusercontent.com/smdn/txline-map-display/images/doc/modules/7M37896_8M49450/8M49450-board-front.jpg) -->
<!-- ![基盤裏面](https://raw.githubusercontent.com/smdn/txline-map-display/images/doc/modules/7M37896_8M49450/8M49450-board-back.jpg) -->

`LED1,2`はともに🟧橙色LED。　12V。

## 接続

|コネクタ|接続モジュール|
|:-------|:---------|
|7M37896 `CN1`|[6M15040](../6M15040/README.md)|
|7M37896 `CN2`|8M49450|
|8M49450 `CN1`|7M37896|

### 7M37896 コネクタ`CN1`

|端子|接続LED|
|---:|:------|
|1|(+12V)|
|2|^|
|3|^|
|4|^|
|5|7M37896 `LED1` 🟩緑|
|6|7M37896 `LED2` 🟩緑|
|7|7M37896 `LED3` 🟩緑|
|8|7M37896 `LED3` 🟥赤|
|9|7M37896 `LED4` 🟩緑|
|10|7M37896 `LED5` 🟩緑|
|11|7M37896 `LED6` 🟥赤|
|12|7M37896 `LED6` 🟩緑|
|13|7M37896 `LED7` 🟩緑|
|14|7M37896 `LED8` 🟩緑|
|15|7M37896 `LED9` 🟥赤|
|16|7M37896 `LED9` 🟩緑|
|17|7M37896 `LED10` 🟩緑|
|18|7M37896 `LED11` 🟩緑|
|19|7M37896 `LED12` 🟥赤|
|20|7M37896 `LED12` 🟩緑|
|21|7M37896 `LED13` 🟩緑|
|22|7M37896 `LED14` 🟩緑|
|23|7M37896 `LED15` 🟥赤|
|24|7M37896 `LED15` 🟩緑|
|25|8M49450 `LED1` 🟧橙|
|26|8M49450 `LED2` 🟧橙|

### 7M37896 コネクタ`CN2`
|端子|ラベル|接続先|
|---:|:-----|:------|
|1   |`LED1`|(+12V)|
|2   |`LED2`|^     |
|3   |`GND1`|8M49450 `LED1`|
|4   |`GND2`|8M49450 `LED2`|

## LED抵抗
- 🟩緑 200Ω 1/4W
- 🟥赤 240Ω 1/4W
- 🟧橙 なし(内蔵?)