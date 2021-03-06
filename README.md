# WpfTreeViewBugSample001
【WPF】TreeViewの上矢印キーでの項目移動の挙動がおかしい。 

C#を使用しWPFアプリケーションを作成しています。今回、TreeViewで挙動がおかしな事がありましたので、メモしておきます。
解決策やヒントなどをご存知の方がいらっしゃいましたら、助言をいただけると助かります。

動作環境
OS:Windows 10 Professional (64ビット)  
バージョン:1803  
プロジェクトのターゲットフレームワーク：.NET Framework 4.6.2  
IDE:Visual Studio Community 2017 Version 15.7.4  

通常、TreeViewの項目を選択する時、上下矢印キーで選択項目を変更できますが、FontSizeを大きくすると、上矢印キーが途中で引っ掛かり、止まってしまいます。
文章で書くと、分かりづらいですが、以下のSSのような TreeView だけの簡単なサンプルプログラムです。表示している項目数は10x50=500項目です。

以下のように、XAML で TreeView の FontSize を "12.0" にすると、上下矢印キーで自由に項目を選択できます。

![FontSize=12.0](https://i.imgur.com/Thl7Mks.jpg "FontSize=12.0")


しかし、以下のように XAML で FontSize="20.0" と大きめの値にすると、下矢印キーで最終項目まで移動できますが、上矢印キーは途中で止まってしまいます。

![FontSize=20.0](https://i.imgur.com/HBmV230.jpg "FontSize=20.0")

上記SSの場面では、上矢印キーを押しているのですが「SubItem-1:1」より上に移動できません。しかし、マウスでひとつ上にある「SubItem-1:0」を選択すると選択状態になり、上矢印キーでまた移動できます。しかし、また途中で引っ掛かってしまいます。

なお、TreeViewの仮想化の有、無共にテストしてみましたが、結果は同じでした。
何か、WPFやTreeViewの使い方を根本的に間違っているのでしょうか？
