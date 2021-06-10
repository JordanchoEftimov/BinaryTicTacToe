## BinaryTicTacToe

Windows Forms проектна задача изработена од: Јорданчо Ефтимов (191156) и Јетон Рамадани (191017).

***

### Опис на апликацијата

  Апликацијата што се развива е класичната игра Икс-Нула (анг. Tic-Tac-Toe) која што ја модифициравме и изменивме со тоа што наместо да се користат Х и О за знаци на играчите, ние ги искористивме 1 и 0. Апликацијата овозможува играње на двајца играчи помеѓу себе, со континуирано водење на резултат помеѓу играчите. Дополнително, постои и тренинг опција, односно опција на играње со компјутерот, во која што постојат 3 нивоа:
- Easy (лесно ниво)
- Medium (средно ниво)
- Hard (тешко ниво)

  Кога играчите играат помеѓу себе, нивниот резултат се зачувува и во посебно мени се води евиденција за најдобрите 10 играчи според поени. Поените се добиваат на следниот начин:
- 3 поени за победа
- 1 поен за нерешено
- -2 поени за пораз

  Играта е направена со минималистички дизајн со цел да биде полесна за употреба од страна на играчите. Изгледнот на апликацијата следи во прилог:
<p align="center">
  <img src="https://i.ibb.co/JnNM8f5/Untitled.png">
</p>

### Упатство за употреба
  1. Играта се стартува со двоен клик на иконката за апликацијата (слика од иконката во прилог):
<p align="center">
  <img src="https://i.ibb.co/XzG4Yft/Untitled.png">
</p>

  2. Откако ќе се отвори почетниот прозорец на играта, достапно ни е менито од левата страна на прозорецот (слика од менито во прилог):
<p align="center">
  <img src="https://i.ibb.co/5FcrGbN/Untitled.png">
</p>

#### Опис на функционалностите за секоја од опциите во менито:
  1. **Play with a friend** - Со клик на оваа опција од менито, се отвора ново прозорче кое што бара да се внесат имињата на двајцата играчи кои што сакаат да играат помеѓу себе.
Слика од прозорчето во прилог:
<p align="center">
  <img src="https://i.ibb.co/RNhH2P0/Untitled.png">
</p>

  При внесување на имињата на играчите и кликање на **OK**, од десната страна на прозорецот на апликацијата се прокажуваат полињата каде што играчите може соодветно да играат.

  2. **Play with a bot** - Со клик на оваа опција од менито, се отвора ново прозорче во кое што соодветно се избира *Difficulty level* за играње со компјутерот. Опциите кои што се достапни се *Easy*, *Medium* и *Hard*. Слика од мениото со *Difficulty levels* во прилог:
<p align="center">
  <img src="https://i.ibb.co/FXQhC5S/Untitled.png">
</p>

  3. **Scoreboard** - Со клик на оваа опција од менито, се отвора статистика за најдобрите 10 играчи според бројот на победи, нерешени и порази.

  4. **Exit** - Со клик на оваа опција од менито, корисникот се прашува дали е сигурен дека сака да излезе од апликацијата. Со кликање на *Yes* апликацијата се исклучува.

#### Изглед на *Gameplay* со играч
<p align="center">
  <img src="https://i.ibb.co/JRGN20L/Untitled.png">
</p>

#### Опис на опциите од менито при играње со играч
  1. **New Game** - При избор на оваа опција, излегува предупредување со што се прашуваат играчите дали сакаат да играат нова игра. Доколку изберат *Yes*, повторно им излегува прозорец со што им се бараат имињата на играчите, и резултатот се ресетира на 0 - 0. Доколку изберат *No*, играта продолжува соодветно.
  2. **Reset** - Со избор на оваа опција, се ресетира само моменталната партија, односно се ресетираат полињата. Резултат останува непроменет, односно играта се пресметува како да завршила нерешено.
  3. **Exit Game** - Со избор на оваа опција, се завршува натпреварот помеѓу двајцата играчи. **Апликацијата не се исклучува со изборот на оваа опција.**

### Опис на функции за развивање на апликацијата
  ##### Фунцкија која се повикува при кликање на поле
  ```csharp
        /// <summary>
        ///     It updates the clicked cell and marks it as played!
        /// </summary>
        private void Field_Click(object sender, EventArgs e)
        {
            // Field and Game Update start
            Button field = (Button) sender;
            int index = int.Parse(field.Name[5] + "") - 1;
            if (Game.Is1or0turn == true)
            {
                Game.Plays[index] = 1;
                field.Text = "1";
            }
            else
            {
                Game.Plays[index] = 0;
                field.Text = "0";
            }
            
            field.Enabled = false;
            Game.TurnsTaken++;
            // Field and Game Update end

            String result = WinCheck(index); // Check winner and disable fileds if end
            Game.Is1or0turn = !Game.Is1or0turn; // Change the turn to next player
            /*
             *  The next part is used to make imediately a bot move if the game didn't finished 
             *  with the last move of the player (depending on the selected mode at the begining).
             */
            if (Bot.botActive && result.Equals("None") && Game.TurnsTaken != 9)
            {
                index = Game.BotMove();
                GameButtons[index].Text = "0";
                GameButtons[index].Enabled = false;

                WinCheck(index);

                Game.Is1or0turn = !Game.Is1or0turn;
            }
        }
  ```

  ##### Функција за компјутерот да направи потег во *Easy difficulty*
  ```csharp
        /// <summary>
        ///     The function generates a random place for the bot!
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <returns>The index where the AI/Bot play (Easy)</returns>
        public static int EasyMove(int[] plays)
        {
            
            while (true)
            {
                int ind = rand.Next(9);
                if (plays[ind] == -1)
                {
                    return ind;
                }
            }
        }
  ```

  ##### Функција за компјутерот да направи потег во *Medium difficulty*
  ```csharp
        /// <summary>
        ///     If the Bot can win with the next move than position will be played, 
        ///     otherwise we check if we can block opponent win on next move and if none of those is possible
        ///     then with the help of easyMove function we generate a random position to play
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <returns>The index where the AI/Bot play (Medium)</returns>
        public static int MediumMove(int[] plays)
        {
            List<int> enemyWin = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (plays[i] == -1)
                {
                    plays[i] = 0;
                    String res = WinnerCheck.CheckWin(plays, i, 0);
                    plays[i] = -1;
                    if (!res.Equals("None"))
                        return i;
                    
                    // Check if enemy can win

                    plays[i] = 1;
                    res = WinnerCheck.CheckWin(plays, i, 1);
                    if (!res.Equals("None"))
                        enemyWin.Add(i);
                    plays[i] = -1;
                }
            }

            // If bot can't win and Enemy can on next move block one possible way
            if (enemyWin.Count != 0)
                return enemyWin[0];

            return EasyMove(plays);
        }
  ```
  
  
  ##### Функција за компјутерот да направи потег во *Hard difficulty*
  ```csharp
        /// <summary>
        ///     This function with the help of minimax algorithm finds the best best move for the AI
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <param name="moves">The number of moves made util now, helps on checking Draw</param>
        /// <returns>The index where the AI/Bot play (Hard)</returns>
        public static int HardMove(int[] plays, int moves)
        {
            // MinMax Algorithm
            
            int maxScore = Int32.MinValue;
            int bestMove = -1;
            for (int i = 0; i < 9; i++)
            {
                if (plays[i] == -1)
                {
                    Moves = moves + 1;
                    plays[i] = 0;
                    int res = Minimax(plays, i, false);
                    if (res > maxScore)
                    {
                        maxScore = res;
                        bestMove = i;
                    }
                    plays[i] = -1;
                }
            }
            return bestMove;
        }
  ```
  
  Дополнително, за подобро да фунцкионира потегот на компјутерот во "Hard" ниво, го имплементиравме MinMax алгоритамот. Во прилог следи изворниот код за тпа:
  ```csharp
  /// <summary>
        ///     The MiniMax algorithm to find the best move for the bot Hard move!
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <param name="lastIndex">The last index of the board where is played! (used in checkWin)</param>
        /// <param name="isMaximizing">true if AI turns, false if the player turn</param>
        /// <returns>Score that depends on the game state AI win = 10pts, Player win = -10pts and Draw = 0pts</returns>
        private static int Minimax(int[] plays, int lastIndex, bool isMaximizing)
        {
            String result = WinnerCheck.CheckWin(plays, lastIndex, isMaximizing ? 1 : 0);
            if (result.StartsWith("Win"))
            {
                return isMaximizing ? -10 : 10; //if ai looses return -10 otherwise 10
            } else if (Moves == 9)
            {
                return 0;
            }

            if (isMaximizing) // Ai Move 
            {
                int bestScore = Int32.MinValue;
                for (int i = 0; i < 9; i++)
                {
                    if (plays[i] == -1)
                    {
                        plays[i] = 0;
                        Moves++;
                        int score = Minimax(plays, i, false);
                        plays[i] = -1;
                        Moves--;
                        bestScore = Math.Max(score, bestScore);
                    }
                }
                
                return bestScore;
            }
            else
            {
                int bestScore = Int32.MaxValue;
                for (int i = 0; i < 9; i++)
                {
                    if (plays[i] == -1)
                    {
                        plays[i] = 1;
                        Moves++;
                        int score = Minimax(plays, i, true);
                        plays[i] = -1;
                        Moves--;
                        bestScore = Math.Min(score, bestScore);
                    }
                }
                return bestScore;
            }
        }
  ```
  
  **Напомена**: Секој од овие функции се објаснети со коментари во самиот код.
  
  
