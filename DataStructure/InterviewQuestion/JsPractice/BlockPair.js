function IsBlockPair(input) {

    var s = [];

    input.split("").forEach(function(c) {
        if (s.length > 0 && s[s.length - 1] == c) {
            s.pop();
        } else {
            s.push(c);
        }
    });

    return s.length == 0;
}