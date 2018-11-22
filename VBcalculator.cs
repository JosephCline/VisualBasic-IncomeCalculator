Module Module1

    Sub Main()
        Dim iHoursworked As Integer
        Dim dPayrate As Decimal
        Dim dWeeklypay As Decimal
        Dim sEmployeename As String
        Dim dOvertimehour As Decimal
        Dim dOvertimepay As Decimal
        Dim dGross As Decimal
        Dim dTotalGross As Decimal
        Dim dTotalGross2 As Decimal

        Console.Write("Please enter your name: ")
        sEmployeename = Console.ReadLine

        Console.Write("Please enter the amount of hours you worked this week: ")
        iHoursworked = Console.ReadLine

        Console.Write("Please enter your current payrate per hour: ")
        dPayrate = Console.ReadLine

        If iHoursworked <= 40 Then
            dWeeklypay = iHoursworked * dPayrate
            Console.Write("Your weekly pay is " & FormatCurrency(dWeeklypay))
            Console.ReadKey()
        Else
            dOvertimehour = iHoursworked - 40           '44 - 40 = 4'
            dGross = (dPayrate * 40) + dPayrate * 1.5 * dOvertimehour       '15 * 4 = 60'
            Console.Write("Your weekly pay is " & FormatCurrency(dGross))
            Console.ReadKey()
        End If




    End Sub

End Module
