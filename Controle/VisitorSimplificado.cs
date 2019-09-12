/*
class MusicLibrary {
    private Set<Music> collection ...
    public Set<Music> getPopMusic() { ... }
    public Set<Music> getRockMusic() { ... }
    public Set<Music> getElectronicaMusic() { ... }
}

interface Visitor<T> {
    visit(Set<T> items);
}

interface MusicVisitor extends Visitor<Music>;

class MusicLibrary {
    private Set<Music> collection ...
    public void accept(MusicVisitor visitor) {
       visitor.visit( this.collection );
    }
}

class RockMusicVisitor implements MusicVisitor {
    private final Set<Music> picks = ...
    public visit(Set<Music> items) { ... }
    public Set<Music> getRockMusic() { return this.picks; }
}
class AmbientMusicVisitor implements MusicVisitor {
    private final Set<Music> picks = ...
    public visit(Set<Music> items) { ... }
    public Set<Music> getAmbientMusic() { return this.picks; }
}

You separate the data from the algorithm. You offload the algorithm to visitor implementations.
You add functionality by creating more visitors, instead of constantly modifying (and bloating) 
the class that holds the data.*/