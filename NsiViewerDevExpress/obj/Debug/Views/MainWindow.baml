   M S B A M L   `   `   `  ����N  JNsiViewerDevExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NsiViewerDevExpressNsiViewerDevExpress  5   	   O,clr-namespace:NsiViewerDevExpress.ViewModelsNsiViewerDevExpress.ViewModels  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   G(clr-namespace:NsiViewerDevExpress.CommonNsiViewerDevExpress.Common  5   	   *    $NsiViewerDevExpress.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v16.1, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:NsiViewerDevExpress     5   	   l hDevExpress.Xpf.Core.v16.1.Extensions, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a=dx2http://schemas.devexpress.com/winfx/2008/xaml/core   5   	   ?
viewModels,clr-namespace:NsiViewerDevExpress.ViewModels   5   	   f bDevExpress.Xpf.Grid.v16.1.Core, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49al	 hDevExpress.Xpf.Grid.v16.1.Extensions, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa
 ]DevExpress.Xpf.Grid.v16.1, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 
 5	   	   j fDevExpress.Xpf.LayoutControl.v16.1, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5
   	   0sys&clr-namespace:System;assembly=mscorlib  5   	   5common(clr-namespace:NsiViewerDevExpress.Common  5   	   ] YDevExpress.Mvvm.v16.1, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5   	   Gdxgt<http://schemas.devexpress.com/winfx/2008/xaml/grid/themekeys 
 5   	   &   DevExpress.Xpf.Core.ThemeManager    	ThemeName0  *DevExpress.Xpf.Core.ThemeNameTypeConverter$  	LightGray 5   	   $	��720��5   	   $
��1200��5   	    � DataContext 5   	   1  +DevExpress.Mvvm.UI.ViewModelSourceExtension     Type2   ,NsiViewerDevExpress.ViewModels.MainViewModel"   � Title 5   	   �� *MainViewTitle+ � 	Resources 5      0  *DevExpress.Xpf.Grid.ColumnTemplateSelector   TemplateSelector  ColumnStyle �� 
TargetType$ 
 DevExpress.Xpf.Grid.GridColumn$  DevExpress.Xpf.Grid.BaseColumn �� Property �� Value  CellStyleForDynamicColumns.  (DevExpress.Xpf.Grid.CellContentPresenter �� BasedOn9	 
 3DevExpress.Xpf.Grid.Themes.GridRowThemeKeyExtension�
  �DevExpress.Xpf.Utils.Themes.ThemeKeyExtensionInternalBase`1[[DevExpress.Xpf.Grid.Themes.GridRowThemeKeys, DevExpress.Xpf.Grid.v16.1, Version=16.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a]]	 
  ResourceKey  RegularColumnTemplate
 �� DataType)   #NsiViewerDevExpress.Common.ColumnEx$  DevExpress.Xpf.Grid.ColumnBase   	CellStyle   ReadOnly.   (NsiViewerDevExpress.Common.BindingHelper   Path   Header7   1NsiViewerDevExpress.Common.ColumnTemplateSelector  ColumnTemplateSelector   DefaultDataTemplate��%�  &	        &	      &	 e     0�� 5       *	  $	 	CellStyle=�+1&	 �     7  &	 9    7    5   
   6%   �� 5   
   "  6$   .�5      ��  �@ MinWidth$	 100��6)   5      �� 5   
   "  5!       5       2  5"      �� 5$   
   "
  65   .R�5%      �� .��5&        8    .   5(      �� *
CellSource+ 5)      �� *Header+5*      5+      5,        5-      8   6K   5.      .��5/      � -   5         �Name$ MainGrid��5/       � RowDefinitions 50   
   �� 51      $
��Auto �6   �� 52      $
��Auto �6   �� 53      $
��Auto �6   �� 54      $
��Auto �6   �� 55      $
��Auto �6   �� 56      $
��Auto �6   �� 57      $
��Auto �6   �� 58      $��1* �6   .+�5;   
   �� $��0��6    �� Orientation$ Vertical=�6"   .+�5<      �� #��["�6   5=      0  *DevExpress.Xpf.LayoutControl.LayoutControl  5?   
   $��1��6   .  (DevExpress.Xpf.LayoutControl.LayoutGroup   Orientation$ 
Horizontal=�6*   .+�5@      �� $
��Auto��5A      $��24��5B      $
��Left=�5C      $��База данных: ��5D      $��Arial)�5E      �� 5G      -   5        $��Filter��5H      $	��325��5I      $��24��5J      $
��Left=�5K       �� DisplayMemberPath$ DbName��5L      ��5M      �� *DbCollection+ �� SelectedItem 5N      �� *
SelectedDb+ �� Mode$ TwoWay=��� 5O      $
��Auto��5P      $��24��5Q      $��Right=�5R      $��Режим Excel:��5S      $��14(�5T      $��Century Gothic)�5U      �� 5V      $
��Auto��5W      $��24��5X      
���  ��$��Right=�5Z      $��14(�5\      $��Century Gothic)�5]      ��5[      �� *	isExcel+5]      5_      �� 5a   
   $��2��6   $ Vertical=�6"   .+�5b      �� #��["�6   5c        5e      $��3��6!   $ 
Horizontal=�6.   .+�5g      �� $	��140��5h      $��25��5i      $
��Left=�5j      $�� Экспорт ��5k      ��5l      �� *PrintCommand+0   *NsiViewerDevExpress.ViewModels.PrintHelper   Instance �� Source# Z ��5m      ��  �� ElementName$ ReferenceRecordView��{�5n      �� *RunExportButtonEnabled+�� 5p      $	��140��5q      $��25��5r      $
��Left=�5s      $�� Импорт ��5v      ��5t      �� *ImportCommand+1   +NsiViewerDevExpress.ViewModels.ImportHelper   Instance# Z ��5u      �� $ ReferenceRecordView��5v      �� 5x      $
��Auto��5y      $��25��5z      $
��Left=�5{      $��Справочник: ��5|      $��Arial)�5}      + 
 %DevExpress.Xpf.Grid.LookUp.LookUpEdit  5      -   5        $	��Nsi��5�      $	��300��5�      $��24��5�      $
��Left=�5�      $��Center=�5�         AutoPopulateColumns .  +  %DevExpress.Xpf.Editors.LookUpEditBase   DisplayMember$ ReferenceName��5�      '  !DevExpress.Xpf.Editors.ButtonEdit   IsTextEditable$ FalseX�5�      *  $DevExpress.Xpf.Editors.PopupBaseEdit   PopupMaxWidth$
 1300Q�5�         PopupMinWidth$	 900Q�5�          ValueMember$  ReferenceId��5�      !   ItemsSource! 5�      �� *NsiCollection+"   SelectedItem" 5�      �� *SelectedNsi+$ TwoWay=�#   StyleSettings# 5�      > 
 8DevExpress.Xpf.Grid.LookUp.SearchLookUpEditStyleSettings  5�      $   PopupContentTemplate$ 5�      �� 5�      .R�5�      % 
 DevExpress.Xpf.Grid.GridControl  $��PART_GridControl��6*   %   Columns% 5�        5�   "   &   	FieldName$& ReferenceId��61   )  #DevExpress.Xpf.Core.ObjectConverter$* $Код справочника НСИ 6I     5�   "   $& ReferenceName��61   $< 6Наименование справочника НСИ 6K     5�   "   $& ReferenceGroupId��61   $9 3Код группы справочников НСИ 6N   '   View' 5�      # 
 DevExpress.Xpf.Grid.TableView  5�   "   (   	AutoWidth( . 60   5�      5�      5�      �� 5�      $
��Auto��5�      $��24��5�      $
��Left=�5�      $&��  Код справочника: ��5�      $��Arial)�5�      �� 5�      $
��Auto��5�      $��24��5�      $
��Left=�5�      $��Arial)�5�      ��5�      �� *SelectedNsi.ReferenceId+) �� Empty* �� TargetNullValue#* Z) 5�      �� 5�      $	��200��5�      $��25��5�      $��Right=�5�      $3��- Сохранить в базу данных ��5�      ��5�      �� *SaveSqlCommand+2  ,NsiViewerDevExpress.ViewModels.SqlSaveHelper+   Instance# Z+ ��5�      �� $ ReferenceRecordView��{�5�      �� *	ExportSQL+5�      �� 5�   
   $��4��6   $ Vertical=�6"   .+�5�      �� #��["�6   5�      � 5�   
   $��5��6   ��5�      �� $ MainGrid��, �� Path$, ActualWidth���5�      �� $ MainGrid��$, ActualHeight�.+�5�        -   5        -  Name$&-  ReferenceAttributeCollectionGrid��5�      )  #DevExpress.Xpf.Grid.DataControlBase.   AutoGenerateColumns$. AddNew=�5�      /   ColumnGeneratorStyle#/ [ 5�      0   ItemsSource0 5�      �� *ReferenceAttributeCollection+ 5�      5   /NsiViewerDevExpress.Common.ConverterRefAttrType  ConverterRefAttrType��%   &	         5�      62   5�      % 5�        5�      $& ReferenceAttributeId��5�      $; 5Код атрибута справочника НСИ 5�       .  5�        5�      $& ReferenceAttributeName��5�      $/ )Наименование атрибута 5�       .  5�        5�      $ Тип атрибута 5�       .  1   DisplayMemberBinding1 5�      �� $, ReferenceAttributeType�2 �� 	Converter#2 [ $ TwoWay=�5�        5�      $& RefReferenceId��5�      $, &Ссылка на справочник 5�       .  5�        5�      $& 
DataAreaId��5�      $$ Код компании в DAX 5�      3   Visible3 .  5�        5�      $& RecId��5�      $  Код записи в DAX 5�      3 .  5�        5�      $& ReferenceId��5�      $* $Код справочника НСИ 5�      3 .  5�        5�      $& GM_NSIReference��6%   3 .  6A     5�      $& RefReference��6%   3 .  6>   ' 5�        5�      4   AllowPerPixelScrolling4 . ( . &   DevExpress.Xpf.Grid.DataViewBase5   NavigationStyle$	5 Row=�5�      & 
  DevExpress.Xpf.Grid.GridViewBase6   ShowGroupPanel6 .  5�      5�      5�      �� 5�   
   $��6��6   $ Vertical=�6"   .+�5�      �� #��["�6   5�      � 5�   
   $��7��5�      ��5�      �� $ MainGrid��$, ActualWidth���5�      �� $ MainGrid��$, ActualHeight�.+�5�        -   5        $- ReferenceRecordGrid��5�      $. AddNew=�5�      &7   ColumnGeneratorTemplateSelector#7 [ 5�      8   SelectionMode$	8 Row=�5�      9   ColumnsSource9 5�      �� *	Columns+0 5�      �� *	Records+:   SelectedItem: 5�      �� $, SelectedAttributeValue�' 5        5     -   5        ;  Name$; ReferenceRecordView��5     ( . <   AllowResizing< . 4 . 6 .  =   ShowColumnHeaders= . >   AllowBestFit> . ?   BestFitArea$	? All=�5
     @   BestFitMode$@ VisibleRows=�5     A   UseLightweightTemplates$
A NoneX�5     5     5     5     5     5     