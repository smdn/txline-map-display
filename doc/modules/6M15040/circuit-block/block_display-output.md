# 表示出力部

## 回路図
![回路図](./block_display-output.svg)

2つの74AC138(`IC13`, `IC14`)で4入力(?)16出力のデマルチプレクサを構成し、8回路×10組のDフリップフロップ・74HC273A(`IC15`〜`IC24`)にクロック信号を出力。　10組の74HC273Aで最大8×10ビット分のデータを保持。

74HC273Aの出力は、それぞれに接続されたトランジスタアレイTD62083(`TA1`〜`TA10`)に入力され、同出力はコネクタ`CN4`〜`CN7`を介して直接LEDの点灯に用いられる。

`TA11`は74AC138を独立して実装されているため、個別に制御される(?)

## パーツ

### 74AC138
1/8 デコーダ・デマルチプレクサ

|pin №|symbol|symbol|pin №|
|-----:|:-----|-----:|:-----|
|1|A<sub>0</sub>|<span style="text-decoration: overline;">O<sub>0</sub></span>|16|
|2|A<sub>1</sub>|<span style="text-decoration: overline;">O<sub>1</sub></span>|15|
|3|A<sub>2</sub>|<span style="text-decoration: overline;">O<sub>2</sub></span>|14|
|4|<span style="text-decoration: overline;">E<sub>1</sub></span>|<span style="text-decoration: overline;">O<sub>3</sub></span>|13|
|5|<span style="text-decoration: overline;">E<sub>2</sub></span>|<span style="text-decoration: overline;">O<sub>4</sub></span>|12|
|6|E<sub>3</sub>|<span style="text-decoration: overline;">O<sub>5</sub></span>|11|
|7|<span style="text-decoration: overline;">O<sub>7</sub></span>|<span style="text-decoration: overline;">O<sub>5</sub></span>|10|
|8|GND|<span style="text-decoration: overline;">O<sub>6</sub></span>|9|

- A<sub>0</sub>-A<sub>2</sub>: Address Iputs
- <span style="text-decoration: overline;">E<sub>1</sub></span>, <span style="text-decoration: overline;">E<sub>2</sub></span>, E<sub>3</sub>: Enable Inputs
- <span style="text-decoration: overline;">O<sub>0</sub></span>-<span style="text-decoration: overline;">O<sub>7</sub></span>: Outputs

|項目|値|
|----|--|
|V<sub>CC</sub>|2.0〜6.0V|
|V<sub>IN</sub>, V<sub>OUT</sub>|0〜V<sub>CC</sub>|

### 74HC273A
8回路 Dフリップフロップ

|pin №|symbol|symbol|pin №|
|-----:|:-----|-----:|:-----|
|1|<span style="text-decoration: overline;">CLR</span>|V<sub>CC</sub>|20|
|2|Q1|Q8|19|
|3|D1|D8|18|
|4|D2|D7|17|
|5|Q2|Q7|16|
|6|Q3|Q6|15|
|7|D3|D6|14|
|8|D4|D5|13|
|9|Q4|Q5|12|
|10|GND|CK|11|

|項目|値|
|----|--|
|V<sub>CC</sub>|2〜6V|
|V<sub>IN</sub>|0〜V<sub>CC</sub>|
|V<sub>OUT</sub>|0〜V<sub>CC</sub>|
|I<sub>CC</sub>|±50mA max|
|I<sub>OUT</sub>|±25mA max|

### TD62083
8ch シンクドライバ トランジスタアレイ

|pin №|symbol|symbol|pin №|
|-----:|:-----|-----:|:-----|
|1|I1|O1|18|
|2|I2|O2|17|
|3|I3|O3|16|
|4|I4|O4|15|
|5|I5|O5|14|
|6|I6|O6|13|
|7|I7|O7|12|
|8|I8|O8|11|
|9|GND|COMMON|10|

|項目|値|
|----|--|
|V<sub>OUT</sub>|50V|
|V<sub>COM</sub>|〜50V|
|I<sub>OUT</sub>|500mA/ch|
|V<sub>IN</sub>|〜30V|
