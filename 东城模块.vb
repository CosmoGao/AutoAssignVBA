Sub ��ȡ���_�ֵ�()

    '����ȷ��
     If MsgBox("��ȷ��Ҫ�ϲ����ļ�����ܱ���ͬһ�ļ��У����ļ�����û�������ļ���", vbOKCancel, "��Ҫ��ʾ") = vbCancel Then
     Exit Sub
     End If
     
    '��������
     Dim MyPath, MyName, AWbName
     Dim wb As Workbook
     Dim Num As Integer
     
    '�ر���Ļ����
     Application.ScreenUpdating = False
    
    '����Ŀ¼�ļ���ʽ������ֵ
     MyPath = ActiveWorkbook.Path
     MyName = Dir(MyPath & "\" & "*.xlsx")
     AWbName = ActiveWorkbook.Name
     Num = 0
        
    'ѭ������
     Do While MyName <> ""                                                      '�����ж�
        
        If MyName <> AWbName Then                                               '�����ļ���
            Set wb = Workbooks.Open(MyPath & "\" & MyName)                      '�������
            Num = Num + 1
                Dim i As Integer
                    Workbooks(AWbName).Activate                                 '������ܱ�
                    i = Num + 2
                    Cells(i, 1) = Left(MyName, 3)                               '��ȡ�ֵ�����
                            
                    For j = 2 To 19
                        Cells(i, j) = wb.Sheets(1).Cells(j, 6)                  '��������ָ��÷�
                    Next
                        
                        Cells(i, 20) = wb.Sheets(1).Cells(2, 4)                 '����ָ��
                        Cells(i, 21) = wb.Sheets(1).Cells(14, 4)                '����ָ��
                        Cells(i, 22) = wb.Sheets(1).Cells(2, 2)                 'һ��ָ��
                        
            wb.Close False                                                      '�رձ�
        End If
            
        MyName = Dir
     Loop
    
     '������Ļ����
      Application.ScreenUpdating = True
     
     'ͳ�ƺϲ�����
      MsgBox "���ϲ���" & Num & "����������", vbInformation, "��ʾ"
    
End Sub

Sub ��ȡ���_��ҵ()

    '����ȷ��
     If MsgBox("��ȷ��Ҫ�ϲ����ļ�����ܱ���ͬһ�ļ��У����ļ�����û�������ļ���", vbOKCancel, "��Ҫ��ʾ") = vbCancel Then
     Exit Sub
     End If
     
    '��������
     Dim MyPath, MyName, AWbName
     Dim wb As Workbook
     Dim Num As Integer
    
    '�ر���Ļ����
     Application.ScreenUpdating = False
    
    
    '����Ŀ¼�ļ���ʽ������ֵ
     MyPath = ActiveWorkbook.Path
     MyName = Dir(MyPath & "\" & "*.xlsx")
     AWbName = ActiveWorkbook.Name
     Num = 0
         
    'ѭ������
     Do While MyName <> ""                                                      '�����ж�
        
        If MyName <> AWbName Then                                               '�����ļ���
            Set wb = Workbooks.Open(MyPath & "\" & MyName)                      '�������
            Num = Num + 1
                Dim i As Integer
                Workbooks(AWbName).Activate                                     '������ܱ�
                i = Num + 2
                Cells(i, 1) = Left(MyName, 3)                                   '��ȡ���ű���
                            
                For j = 2 To 18
                    Cells(i, j) = wb.Sheets(1).Cells(j, 6)                      '��������ָ��÷�
                Next
                                
                    Cells(i, 19) = wb.Sheets(1).Cells(2, 4)                     '����ָ��
                    Cells(i, 20) = wb.Sheets(1).Cells(9, 4)                     '����ָ��
                    Cells(i, 21) = wb.Sheets(1).Cells(2, 2)                     'һ��ָ��
                
                For k = 22 To 31
                    Cells(i, k) = wb.Sheets(1).Cells(k - 13, 5)                 '����ָ������
                Next
                
            wb.Close False                                                      '�رձ�
        End If
        
        MyName = Dir
     Loop
    
    '������Ļ����
     Application.ScreenUpdating = True
     
    'ͳ�ƺϲ�����
     MsgBox "���ϲ���" & Num & "����������", vbInformation, "��ʾ"
       
End Sub



Sub �ֽ�÷ֱ�_��ҵ()
    
    Dim wb, awb As Workbook
    Dim i, j As Integer
    AWbName = ActiveWorkbook.Name
    Set awb = Workbooks(AWbName)
    For i = 2 To 18
        Set wb = Workbooks.Open("C:\Users\GaoYH\Desktop\����\Database\����\" & Cells(i, 1) & "����÷�.xlsx")
            
        For j = 14 To 19
            wb.Sheets(1).Cells(j, 8) = awb.Sheets(1).Cells(i, j - 10)
        Next
        
        wb.Save
        wb.Close False
    Next
    
End Sub



Sub �ֽ�÷ֱ�_����()
    
    Dim wb, awb As Workbook
    Dim i, j As Integer
    
    AWbName = ActiveWorkbook.Name
    Set awb = Workbooks(AWbName)
    
    For i = 2 To 18
        Set wb = Workbooks.Open("C:\Users\GaoYH\Desktop\����\Database\����\" & Cells(i, 1) & "����÷�.xlsx")
        
        For j = 2 To 13
            wb.Sheets(1).Cells(j, 8) = awb.Sheets(1).Cells(i, j + 2)
        Next
    
        wb.Save
        wb.Close False
    Next
    
End Sub


