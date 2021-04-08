# 森尾電機 6M15040
停車駅・進行方向・開閉ドア表示制御モジュール

![基盤表面](https://github.com/smdn/txline-map-display/blob/images/doc/modules/6M15040/board-front.jpg)
![基盤裏面](https://github.com/smdn/txline-map-display/blob/images/doc/modules/6M15040/board-back.jpg)

## インターフェイス
RS-485/RS-422(?)

(`IC3` [MAX1480BEPI](IC3/README.md))

### プロトコル・コマンド
不明

## 接続

### コネクタ`CN1`
|端子|ラベル    |接続先|
|---:|:---------|:-----|
|1   |`GG`      |[ターミナルブロック](../terminal-block/README.md) 端子`1`|
|2   |`5VGND`   |[SVS05SA](../SVS05SA/README.md) 端子`0`|
|3   |`5V`      |[SVS05SA](../SVS05SA/README.md) 端子`+5V`|
|4   |`12GND`   |[BNT12SA-M](../BNT12SA-M/README.md) コネクタ`CN51`端子`2`|
|5   |`12V`     |[BNT12SA-M](../BNT12SA-M/README.md) コネクタ`CN51`端子`4`|

### コネクタ`CN2`
|端子|ラベル    |接続先|
|---:|:---------|:-----|
|1   |`TS541`   |[コネクタ](../external-connector/README.md)|
|2   |-         |-|
|3   |`TS542`   |[コネクタ](../external-connector/README.md)|
|4   |-         |-|
|5   |`TERM1`   |[コネクタ](../external-connector/README.md)|
|6   |`TS543`   |[コネクタ](../external-connector/README.md)|
|7   |-         |-|
|8   |`TERM2`   |[コネクタ](../external-connector/README.md)|

### コネクタ`CN3`
(接続先なし)

|端子|ラベル    |接続先|
|---:|:---------|:-----|
|1   |-         |-|
|2   |-         |-|
|3   |-         |-|
|4   |-         |-|
|5   |-         |-|
|6   |-         |-|

### コネクタ`CN4`〜`CN7`
[日本航空電子工業 PS シリーズ SENタイプ](https://www.jae.com/connectors/series/detail/id=64318&type_code=T1040)

|コネクタ|接続モジュール|
|-------:|:---------|
|`CN4`|[7M37895](../7M37895/README.md) 1/3|
|`CN5`|[7M37895](../7M37895/README.md) 2/3|
|`CN6`|[7M37895](../7M37895/README.md) 3/3|
|`CN7`|[7M37896](../7M37896_8M49450/README.md)|

## 主要IC
- `IC1` [NEC D78P214CW](IC1/README.md)
- `IC2` [NEC D72002CZ-11](IC2/README.md)
- `IC3` [Maxim MAX1480BEPI](IC3/README.md)
- `IC4` [STMicroelectronics M27C1001-10F1](IC4/README.md)
- `IC5` [NEC D431000AGZ-70LL-KJH](IC5/README.md)

# 原状写真
![原状写真](https://github.com/smdn/txline-map-display/blob/images/doc/modules/6M15040/original-condition_0.jpg)
![原状写真](https://github.com/smdn/txline-map-display/blob/images/doc/modules/6M15040/original-condition_1.jpg)
![原状写真・ケーブル](https://github.com/smdn/txline-map-display/blob/images/doc/modules/6M15040/original-condition_cable.jpg)
