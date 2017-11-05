Sub JournalIndexTest()
'
' JournalIndexTest Macro
'

    Dim N As Integer
    N = 300 ' maximum number of rows in spreadsheet
	
	' sort by category
    Range(Cells(1, "A"), Cells(N, "C")).Sort key1:=Range("A1"), _
        order1:=xlAscending, Header:=xlNo
		
    Dim i As Integer
    Dim category As String
    i = 1
    Do While i < N
        category = Cells(i, "A").Value
        Dim j As Integer
        j = i + 1
        
		' delete duplicated category cells
        Do While StrComp(Cells(j, "A").Value, category) = 0 And j < N
            Cells(j, "A").Value = ""
            j = j + 1
        Loop

        ' sort by subcategory
        Range(Cells(i, "B"), Cells(j - 1, "C")).Sort key1:=Range("B1"), _
            order1:=xlAscending, Header:=xlNo
        
        ' delete duplicated subcategory cells
        For k = i To j - 1
            subcategory = Cells(k, "B").Value
            Dim l As Integer
            l = k + 1
            
            Do While StrComp(Cells(l, "B").Value, subcategory) = 0 And l < j
                Cells(l, "B").Value = ""
                l = l + 1
            Loop
        Next
        
        i = j
    Loop
End Sub