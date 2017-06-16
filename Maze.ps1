$_MazeRow = 1;
$_MazeCol = 1;
$_MazeHeight = 10;
$_MazeWeight = 10;

[int[][]] $_DirectionArray = @(
    (1,1,1),(1,1,1),(1,1,1),(1,1,1),(1,1,1),(1,1,1),(1,1,1),(1,1,1),(1,1,1)
)

[int[][]]$maze = @(
    (1,1,1,1,1,1,1,1,1,1),
    (1,0,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,1),
    (1,1,1,1,1,1,1,1,1,0)
)

function PrintMaze(){
    for($i = 0;$i -lt $maze.Length; $i ++){

        Write-Host "";
        for($j = 0;$j -lt $maze.Length;$j++){
        

            if ($maze[$i][$j] -eq 0){
                Write-Host -NoNewline -ForegroundColor Red $maze[$i][$j];
            }else{
                Write-Host -NoNewline $maze[$i][$j];
            }
        }
    }
}

function InitLocation([int[][]]$mazeInput){
   
    $_DirectionArray[0] = @( $_MazeRow, $_MazeCol, $mazeInput[$_MazeRow][$_MazeCol] )
    $_DirectionArray[1] = @( ($_MazeRow - 1), $_MazeCol, $mazeInput[($_MazeRow - 1)][$_MazeCol] )
    $_DirectionArray[2] = @( ($_MazeRow - 1), ($_MazeCol + 1), $mazeInput[($_MazeRow - 1)][($_MazeCol + 1)] )
    $_DirectionArray[3] = @( $_MazeRow, ($_MazeCol + 1), $mazeInput[$_MazeRow][($_MazeCol + 1)] )
    $_DirectionArray[4] = @( ($_MazeRow + 1), ($_MazeCol + 1), $mazeInput[($_MazeRow + 1)][($_MazeCol + 1)] )
    $_DirectionArray[5] = @( ($_MazeRow + 1), $_MazeCol, $mazeInput[($_MazeRow + 1)][$_MazeCol] )
    $_DirectionArray[6] = @( ($_MazeRow + 1), ($_MazeCol - 1), $mazeInput[($_MazeRow + 1)][($_MazeCol - 1)] )
    $_DirectionArray[7] = @( $_MazeRow, ($_MazeCol - 1), $mazeInput[$_MazeRow][($_MazeCol - 1)] )
    $_DirectionArray[8] = @( ($_MazeRow - 1), ($_MazeCol - 1), $mazeInput[($_MazeRow - 1)][($_MazeCol - 1)] )
}


############################################################

function RrandomWalking(){
    InitLocation -mazeInput $maze
    
    [int]$direction = Get-Random -minimum 1 -maximum 9
    #[int]$direction = 3;
    
    $row = $_DirectionArray[$direction][0];
    $col = $_DirectionArray[$direction][1];
    
    
    if ($row -eq 0 -or $row -eq 6 -or $col -eq 0 -or $col -eq 6)
    {
        Write-Host -ForegroundColor DarkYellow 'Touch the Edge.'
    }else{
    
        switch ($direction) 
        #switch (3) 
        { 
            3 {
                    
                    [int]$tmpMax = [math]::floor(($_MazeWeight - $col - 1)/2 + 1)
                    $RandomWalkCount = Get-Random -minimum 1 -maximum $tmpMax;
                    Write-Host -ForegroundColor Green "Direction:  3 >";
                    Write-Host -ForegroundColor Green "WalkCount:  $RandomWalkCount";
    
                    $_MazeCol = $col + $RandomWalkCount;
    
                    for($i = 0;$i -lt $RandomWalkCount;$i++){
                        $maze[$row][$col++] = 0;
                    }
            } 
            4 {
                    
                    [int]$tmpMax = [math]::Max( [math]::floor(($_MazeHeight - $row - 1)/2 + 1),[math]::floor(($_MazeWeight - $col - 1)/2 + 1))
                    
                    $RandomWalkCount = Get-Random -minimum 1 -maximum $tmpMax;
                    Write-Host -ForegroundColor Green "Direction:  4 >v";
                    Write-Host -ForegroundColor Green "WalkCount:  $RandomWalkCount";
    
                    $_MazeRow = $row + $RandomWalkCount;
                    $_MazeCol = $col + $RandomWalkCount;
    
                    for($i = 0;$i -lt $RandomWalkCount;$i++){
                        $maze[$row++][$col++] = 0;
                    }
            } 
            5 {
                    
                    [int]$tmpMax = [math]::floor(($_MazeHeight - $row - 1)/2 + 1)
                    $RandomWalkCount = Get-Random -minimum 1 -maximum $tmpMax;
                    Write-Host -ForegroundColor Green "Direction:  5 v";
                    Write-Host -ForegroundColor Green "WalkCount:  $RandomWalkCount";
    
                    $_MazeRow = $row + $RandomWalkCount;
    
                    for($i = 0;$i -lt $RandomWalkCount;$i++){
                        $maze[$row++][$col] = 0;
                    }
                    
            } 
            default {"Wrong."}
        }
    }

}



RrandomWalking;


PrintMaze
Write-Host
Write-Host "($_MazeRow,$_MazeCol)"