Option Explicit
Sub Step2_1()
    
    '�¶ȱ�����������˾���
    '�˴���ĳ������ʺ�ĳ������㼰ģ�������й�����
    
    Dim i As Integer
    Dim month As String
    month = InputBox("�������·�", "�·�", "��")
    For i = 1 To 11
        
        Workbooks(month & "�����.xlsx").Activate

        '���Ƶ���Ӧ��˾��
        Sheets(i).Copy before:=Workbooks("����������Ϣͳ�� - " & Sheets(i).[b1] & ".xlsx").Sheets(2)
        
        Workbooks(month & "�����.xlsx").Activate

        Sheets(i).Copy before:=Workbooks("����������Ϣͳ�� - " & Sheets(i).[b1] & ".xlsx").Sheets(2)
        
        '��λ��Ԫ��
        Sheets(1).Select
        
        [a1].Select
        
    Next
    
    '���Թر�ĳ������ʺ�����㹤��������ģ���еĹ������������
    
End Sub

Sub Step2_2()
    
    '��ȡ������·��ɾ��������
    
    '�ر���Ļ����
    Application.ScreenUpdating = False
    
    Dim i, n As Integer
    
    n = Application.CountA(Sheets(2).Range("4:4")) - 2
    
    
    For i = 1 To n
        
        '��ȡ������·
        Sheets(1).Cells(3, 6 * i - 4) = Sheets(2).Cells(4, i + 1)
        
    Next

   
    'ɾ��������
    Range(Columns(6 * n + 2), Columns(1801)).Delete

    '������Ļ����
    Application.ScreenUpdating = True

    [a1] = "��·�Ѷ�ȡ"
        [a1].Select
            With Selection.Interior
                .Pattern = xlSolid
                PatternColorIndex = xlAutomatic
                .Color = 255
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With

End Sub


Sub Step2_3()
 
    '�ر���Ļ����
    Application.ScreenUpdating = False
    
    Dim i, j, n As Integer
    
    n = Application.CountA(Sheets(2).Range("4:4")) - 2
    
    For i = 7 To 88
        
        For j = 1 To n
        
            '����ʶ�ȡ
            Cells(i, 6 * j - 4) = Application.IfNa(Application.VLookup(Cells(i, 1), Sheets(2).Cells, Application.Match(Cells(3, 6 * j - 4), Sheets(2).[4:4], 0), 0), 0)
            
            '������ȡ
            Cells(i, 6 * j - 1) = Application.IfNa(Application.VLookup(Cells(i, 1), Sheets(3).Cells, Application.Match(Cells(3, 6 * j - 4), Sheets(3).[4:4], 0), 0), 0)
        
        Next
    Next
    
    '������Ļ����
    Application.ScreenUpdating = True
    
    [a1] = "����Ѳ�ѯ"
        [a1].Select
            With Selection.Interior
                .Pattern = xlSolid
                .PatternColorIndex = xlAutomatic
                .Color = 255
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With

End Sub


Sub Step2_4()
    
    '��͡��ٷֱ�
    
    '�ر���Ļ����
    Application.ScreenUpdating = False
    
    Dim i, j, n As Integer
    
    n = Application.CountA(Range("5:5"))
    
    For i = 1 To n
    
        '��һ���֣����ļ�������͹�ʽ
        
        '����
        
            'Ͷ��
            Cells(8, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(9, i * 3 - 1), Cells(14, i * 3 - 1)))
            
            '������
            Cells(15, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(16, i * 3 - 1), Cells(30, i * 3 - 1)))
            
            '����
            Cells(31, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(32, i * 3 - 1), Cells(37, i * 3 - 1)))
        
        Cells(7, i * 3 - 1) = Cells(8, i * 3 - 1) + Cells(15, i * 3 - 1) + Cells(31, i * 3 - 1)
        
        '��ȫ
        
            'Ͷ��
            Cells(39, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(40, i * 3 - 1), Cells(46, i * 3 - 1)))
            
            '��ȫ����
            Cells(47, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(48, i * 3 - 1), Cells(56, i * 3 - 1)))
        
        Cells(38, i * 3 - 1) = Cells(39, i * 3 - 1) + Cells(47, i * 3 - 1)
        
        '��Ӫ
        
            'Ͷ��
            Cells(58, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(59, i * 3 - 1), Cells(62, i * 3 - 1)))
            
            '��Ӫ����
            Cells(63, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(64, i * 3 - 1), Cells(77, i * 3 - 1)))
        
        Cells(57, i * 3 - 1) = Cells(58, i * 3 - 1) + Cells(63, i * 3 - 1)
        
        '����
            
            '����Ͷ��
            Cells(79, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(80, i * 3 - 1), Cells(81, i * 3 - 1)))
        
            '��������
            Cells(82, i * 3 - 1) = Application.WorksheetFunction.Sum(Range(Cells(83, i * 3 - 1), Cells(88, i * 3 - 1)))

            
        Cells(78, i * 3 - 1) = Cells(79, i * 3 - 1) + Cells(82, i * 3 - 1)
        
        
        '�ڶ����֣����İٷֱ��м��㹫ʽ
        
        For j = 7 To 88
            
            Cells(j, i * 3 + 1) = Cells(j, i * 3 - 1) / (Cells(7, i * 3 - 1) + Cells(38, i * 3 - 1) + Cells(57, i * 3 - 1) + Cells(78, i * 3 - 1))
            
        Next
    
    Next
    
    '������Ļ����
    Application.ScreenUpdating = True
    
    [a1] = "������Ѽ���"
        [a1].Select
            With Selection.Interior
                .Pattern = xlSolid
                .PatternColorIndex = xlAutomatic
                .Color = 255
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With

End Sub


Sub Step2_5()
    
    '�����ļ�����
    
    '�ر���Ļ����
    Application.ScreenUpdating = False
    
    Dim i, n As Integer
    Dim year, month As String
    year = InputBox("�������������", "���", "2015")
    month = InputBox("����������ʱ���", "ʱ���", "��")
    n = Application.CountA(Sheets(2).[4:4]) - 2
    Sheets("���").[a1] = year
    Sheets("ʱ���").[a1] = month
    Sheets(1).[b1] = Sheets(2).[b1] & "�����������ݡ���" & Sheets("���").[a1] & "��" & Sheets("ʱ���").[a1]
    Sheets(1).[b2] = Sheets(2).[b1] & "��˾"
    
    Sheets("����").Select
    
    [b2] = Sheets(2).[b1]
    [c:c].Clear
    [c1] = "��·"
    For i = 2 To n + 1
        
        Cells(i, 3) = Sheets(2).Cells(4, i)
        
    Next
    
    [d2] = n
    Sheets("����������").[b2] = n * 6
    Sheets(2).Delete
    Sheets(2).Delete
    Sheets(1).Select
    
    [a1].Select
     '������Ļ����
     Application.ScreenUpdating = True
     
    [a1] = "ָ��"
        [a1].Select
            With Selection.Interior
                .Pattern = xlNone
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With
            
End Sub