# つくばエクスプレス車内マップ式表示器解析プロジェクト
[つくばエクスプレス](https://www.mir.co.jp/) [TX-1000系](https://ja.wikipedia.org/wiki/%E9%A6%96%E9%83%BD%E5%9C%8F%E6%96%B0%E9%83%BD%E5%B8%82%E9%89%84%E9%81%93TX-1000%E7%B3%BB%E9%9B%BB%E8%BB%8A)/[2000系](https://ja.wikipedia.org/wiki/%E9%A6%96%E9%83%BD%E5%9C%8F%E6%96%B0%E9%83%BD%E5%B8%82%E9%89%84%E9%81%93TX-2000%E7%B3%BB%E9%9B%BB%E8%BB%8A)車両の車内マップ式表示器([森尾電機](http://www.morio.co.jp/)・2004年3月製造)を解析して動作させるプロジェクトです。

![外観](https://github.com/smdn/txline-map-display/blob/images/doc/exterior-frontside.jpg)
![銘板](https://github.com/smdn/txline-map-display/blob/images/doc/nameplate.jpg)

# ライセンス / License
本プロジェクトは[MITライセンス](LICENSE)に基づき公開されています。

This project is published under the MIT License, see [LICENSE](LICENSE).

## 重要事項の通知 / Important notice
本プロジェクトは、[正規に販売され、入手したもの](doc/misc/purchase-receipt.md)を元にした内容を公開していますが、分解・調査・解析、およびその結果の公開については、製造元の許諾や確認を得ずに行っています。

本プロジェクトの内容の参照・クローン・フォークなどを行う際は、その結果として生じる事項について、上記[ライセンス](LICENSE)に記載のとおり、本プロジェクトは一切の責任を負わないことを認識した上で行ってください。

# 目標
- [ ] 代替制御モジュールでの動作
  - [x] 内部構成の調査・配線の記録
  - [ ] 代替制御モジュールの作成
  - [ ] 制御ソフトウェアの作成
- [ ] 原状での動作
  - [ ] 制御モジュール[6M15040](doc/modules/6M15040/README.md)の動作把握 ([issue #1](../../issues/1))
    - [ ] インターフェイス
    - [ ] プロトコル・コマンド

# 調査・解析内容
- [モジュール](doc/modules/README.md)

