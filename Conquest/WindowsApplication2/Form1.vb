Public Class Form1

    Dim RND As New Random
    Public RegionTaken As Button
    Dim rgnRegions(32) As String
    Public Attack As Boolean = False
    Dim Regioncollide As String
    Dim strZoneConnection() As String
    Public Player1Str As Short
    Public Player2Str As Short
    Dim Player1terr() As Button = {Me.Region24}
    Dim Player2terr() As Button = {Me.Region19}
    Dim blnAttack1 As Boolean
    Dim blnAttack2 As Boolean
    Dim blnAttack3 As Boolean
    Dim blnDefend1 As Boolean
    Dim blnDefend2 As Boolean
    Dim blnDefend3 As Boolean
    Dim blnAttack4 As Boolean
    Dim blnAttack5 As Boolean
    Dim blnAttack6 As Boolean
    Dim blnDefend4 As Boolean
    Dim blnDefend5 As Boolean
    Dim blnDefend6 As Boolean
    Dim P1Wins As Short = 0
    Dim P2Wins As Short = 0
    Dim RedLife As Boolean
    Dim BlueLife As Boolean
    Dim cancel As Boolean = False
    Dim player1Moves As String = 0
    Dim player2Moves As String = 0
    Dim Playerturn As Short = 1
    Dim strRegion() As String
    Dim btnCountries() As Button = {Me.Capitol, Me.Region1, Me.Region2, Me.Region3, Me.Region4, Me.Region5, Me.Region6, Me.Region7, Me.Region8, Me.Region9, Me.Region10, Me.Region11, Me.Region12, Me.Region13, Me.Region14, Me.Region15, Me.Region16, Me.Region17, Me.Region18, Me.Region19, Me.Region20, Me.Region21, Me.Region22, Me.Region23, Me.Region24, Me.Region25, Me.Region26}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to The Game of Conquest! the rules are simple, it is a two player adventure and the player captures territories by clicking and attacking another territory. There is no way to back out of a fight so make your moves wisely. >:) Have Fun!")
        btnCountries(0) = Capitol
        btnCountries(1) = Region1
        btnCountries(2) = Region2
        btnCountries(3) = Region3
        btnCountries(4) = Region4
        btnCountries(5) = Region5
        btnCountries(6) = Region6
        btnCountries(7) = Region7
        btnCountries(8) = Region8
        btnCountries(9) = Region9
        btnCountries(10) = Region10
        btnCountries(11) = Region11
        btnCountries(12) = Region12
        btnCountries(13) = Region13
        btnCountries(14) = Region14
        btnCountries(15) = Region15
        btnCountries(16) = Region16
        btnCountries(17) = Region17
        btnCountries(18) = Region18
        btnCountries(19) = Region19
        btnCountries(20) = Region20
        btnCountries(21) = Region21
        btnCountries(22) = Region22
        btnCountries(23) = Region23
        btnCountries(24) = Region24
        btnCountries(25) = Region25
        btnCountries(26) = Region26
        Player1terr(0) = Region24
        Player2terr(0) = Region19
        Region24.BackColor = Color.Red
        Region19.BackColor = Color.Blue
        pxbPlayer1.Visible = True
        pxbPlayer2.Visible = False
        Call Disableterr2()
    End Sub
    Sub gameload()

        Region24.BackColor = Color.Red
        Region19.BackColor = Color.Blue
        If P1Wins > 1 Then
            For i = 0 To btnCountries.Length - 1
                btnCountries(i).BackColor = Color.White
            Next
        End If
    End Sub
    Sub Disableterr1()
        'This disables player 1's regions
        For i = 0 To btnCountries.Length - 1
            If btnCountries(i).BackColor = Color.Red Then
                btnCountries(i).Enabled = False
            End If
            If btnCountries(i).BackColor = Color.White Then
                btnCountries(i).Enabled = False
            End If
        Next

    End Sub
    Sub Disableterr2()
        'This disables player 2's regions
        For i = 0 To btnCountries.Length - 1
            If btnCountries(i).BackColor = Color.Blue Then
                btnCountries(i).Enabled = False
            End If
            If btnCountries(i).BackColor = Color.White Then
                btnCountries(i).Enabled = False
            End If
        Next

    End Sub
    Sub Disable()
        'This disables the regions too far away from the attacking region
        For i = 0 To btnCountries.Length - 1
            btnCountries(i).Enabled = False
        Next
    End Sub
    Sub Enable()
        'This enables all the regions after the turn
        For i = 0 To btnCountries.Length - 1
            btnCountries(i).Enabled = True
        Next
    End Sub
    Sub Main()
        Dim s As String = Regioncollide

        Dim words As String() = s.Split(New Char() {","})

        Dim word As String
        For Each word In words
            word = word
        Next

        For index = 0 To words.Length - 1
            If words(index) = "00" Then
                Capitol.Enabled = True
            End If
            If words(index) = "01" Then
                Region1.Enabled = True
            End If
            If words(index) = "02" Then
                Region2.Enabled = True
            End If
            If words(index) = "03" Then
                Region3.Enabled = True
            End If
            If words(index) = "04" Then
                Region4.Enabled = True
            End If
            If words(index) = "05" Then
                Region5.Enabled = True
            End If
            If words(index) = "06" Then
                Region6.Enabled = True
            End If
            If words(index) = "07" Then
                Region7.Enabled = True
            End If
            If words(index) = "08" Then
                Region8.Enabled = True
            End If
            If words(index) = "09" Then
                Region9.Enabled = True
            End If
            If words(index) = "10" Then
                Region10.Enabled = True
            End If
            If words(index) = "11" Then
                Region11.Enabled = True
            End If
            If words(index) = "12" Then
                Region12.Enabled = True
            End If
            If words(index) = "13" Then
                Region13.Enabled = True
            End If
            If words(index) = "14" Then
                Region14.Enabled = True
            End If
            If words(index) = "15" Then
                Region15.Enabled = True
            End If
            If words(index) = "16" Then
                Region16.Enabled = True
            End If
            If words(index) = "17" Then
                Region17.Enabled = True
            End If
            If words(index) = "18" Then
                Region18.Enabled = True
            End If
            If words(index) = "19" Then
                Region19.Enabled = True
            End If
            If words(index) = "20" Then
                Region20.Enabled = True
            End If
            If words(index) = "21" Then
                Region21.Enabled = True
            End If
            If words(index) = "22" Then
                Region22.Enabled = True
            End If
            If words(index) = "23" Then
                Region23.Enabled = True
            End If
            If words(index) = "24" Then
                Region24.Enabled = True
            End If
            If words(index) = "25" Then
                Region25.Enabled = True
            End If
            If words(index) = "26" Then
                Region26.Enabled = True
            End If
        Next index
        Attack = True
    End Sub
    Private Sub Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Capitol.Click, Region1.Click, Region2.Click, Region3.Click, Region4.Click, Region5.Click, Region6.Click, Region7.Click, Region8.Click, Region9.Click, Region10.Click, Region11.Click, Region12.Click, Region13.Click, Region14.Click, Region15.Click, Region16.Click, Region17.Click, Region18.Click, Region19.Click, Region20.Click, Region21.Click, Region22.Click, Region23.Click, Region24.Click, Region25.Click, Region26.Click
        'This is the main click event, all the buttons are handled through this event
        'everything depends on this one event sorting out where it has to go
        RegionTaken = sender
        Dim temp As String
        temp = sender.tag
        Regioncollide = temp.ToString
        If Playerturn = 2 Then
            Playerturn = 1
        ElseIf Playerturn = 1 Then
            Playerturn = 2
        End If
        If Attack = False Then
            Call Disable()
            Call Main()
        Else
            Call Fight()
        End If
    End Sub
    Sub Fight()
        'This is when a region has been selected to be attacked
        'the outcome either changes the state of the region or leaves it alone

        'RANDOMIZATION!!!!
        Randomize()
        Dim shtAttackDice1 As Short = RND.Next(1, 7)
        Dim shtAttackDice2 As Short = RND.Next(1, 7)
        Dim shtAttackDice3 As Short = RND.Next(1, 7)
        Dim shtDefendDice1 As Short = RND.Next(1, 7)
        Dim shtDefendDice2 As Short = RND.Next(1, 7)
        Dim shtDefendDice3 As Short = RND.Next(1, 7)
        Dim shtAttackDice4 As Short = RND.Next(1, 7)
        Dim shtAttackDice5 As Short = RND.Next(1, 7)
        Dim shtAttackDice6 As Short = RND.Next(1, 7)
        Dim shtDefendDice4 As Short = RND.Next(1, 7)
        Dim shtDefendDice5 As Short = RND.Next(1, 7)
        Dim shtDefendDice6 As Short = RND.Next(1, 7)

        'This is the dice-roll that decides the outcome
        If shtAttackDice1 > shtDefendDice1 Then
            blnAttack1 = True
        Else
            blnAttack1 = False
        End If
        If shtAttackDice2 > shtDefendDice2 Then
            blnAttack2 = True
        Else
            blnAttack2 = False
        End If
        If shtAttackDice3 > shtDefendDice3 Then
            blnAttack3 = True
        Else
            blnAttack3 = False
        End If
        If shtAttackDice4 > shtDefendDice4 Then
            blnAttack4 = True
        Else
            blnAttack4 = False
        End If
        If shtAttackDice5 > shtDefendDice6 Then
            blnAttack5 = True
        Else
            blnAttack5 = False
        End If
        If shtAttackDice6 > shtDefendDice6 Then
            blnAttack6 = True
        Else
            blnAttack6 = False
        End If

        'this is the victory conditions to take over a region

        'attack 1, 2, 3, 4, 5, 6
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack4 And blnAttack5 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1, 2, 3, 4, 5
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack4 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1, 2, 3, 4, 6
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack4 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1, 2, 3, 4
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack4 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1, 2, 3, 5
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1, 2, 3, 6
        If blnAttack1 And blnAttack2 And blnAttack3 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1 & 2
        If blnAttack1 And blnAttack2 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1 & 3
        If blnAttack1 And blnAttack3 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1 & 4
        If blnAttack1 And blnAttack4 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1 & 5
        If blnAttack1 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 1 & 6
        If blnAttack1 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 2 & 3
        If blnAttack2 And blnAttack3 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 2 & 4
        If blnAttack2 And blnAttack4 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 2 & 5
        If blnAttack2 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 2 & 6
        If blnAttack2 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 3 & 5
        If blnAttack3 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 3 & 6
        If blnAttack3 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 4 & 5
        If blnAttack4 And blnAttack5 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 4 & 6
        If blnAttack4 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'attack 5 & 6
        If blnAttack5 And blnAttack6 = True Then
            If Playerturn = 1 Then
                RegionTaken.BackColor = Color.Red
            End If
            If Playerturn = 2 Then
                RegionTaken.BackColor = Color.Blue
            End If
        End If
        'this is the advantage for capturing the capitol and having more territories
        For i = 0 To btnCountries.Length - 1
            If Playerturn = 1 Then
                If btnCountries(8).BackColor = Color.Red Then
                    blnAttack1 = True
                    blnAttack2 = True
                    blnAttack3 = True
                    blnAttack4 = True
                ElseIf btnCountries(0).BackColor = Color.Blue Then
                    blnAttack1 = False
                    blnAttack3 = False
                    blnAttack6 = False
                End If
            ElseIf Playerturn = 2
                If btnCountries(8).BackColor = Color.Blue Then
                    blnAttack1 = True
                    blnAttack2 = True
                    blnAttack3 = True
                    blnAttack4 = True
                ElseIf btnCountries(0).BackColor = Color.Red Then
                    blnAttack1 = False
                    blnAttack3 = False
                    blnAttack6 = False
                End If
            End If
            'this is the advantage to capturing neutral territories
            If btnCountries(i).BackColor = Color.White Then
                blnAttack3 = True
                blnAttack4 = True
                blnAttack5 = True
                blnAttack6 = True
            End If
        Next

        'this resets the turn and resets the regions
        Call Enable()
        Attack = False
        If Playerturn = 1 Then
            Playerturn = 2
            pxbPlayer2.Visible = True
            pxbPlayer1.Visible = False
            player1Moves = player1Moves.ToString + 1
            Call Disableterr1()
            lblMoves1.Text = "Moves: " + player1Moves
        ElseIf Playerturn = 2 Then
            Playerturn = 1
            pxbPlayer2.Visible = False
            pxbPlayer1.Visible = True
            player2Moves = player2Moves.ToString + 1
            Call Disableterr2()
            lblMoves2.Text = "Moves: " + player2Moves
        End If
        RedLife = False
        BlueLife = False

        For i = 0 To btnCountries.Length - 1
            If btnCountries(i).BackColor = Color.Red Then
                RedLife = True
            ElseIf btnCountries(i).BackColor = Color.Blue Then
                BlueLife = True
            End If
        Next
        If RedLife = False Then
            MessageBox.Show("Blue Wins!")
            P2Wins += 1
            Label2.Text = "Wins: " + P2Wins.ToString
            Call gameload()
        ElseIf BlueLife = False Then
            MessageBox.Show("Red Wins!")
            P1Wins += 1
            Label1.Text = "Wins: " + P1Wins.ToString
            Call gameload()
        End If

    End Sub

    'and tha tha thats all folks!

End Class
