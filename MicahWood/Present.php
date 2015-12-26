<?php

class Present {

  protected $size;
  protected $clatters;
  protected $weight;
  protected $giver;

  public function __construct($description) {
    $this->size = $description['size'];
    $this->clatters = $description['clatters'];
    $this->weight = $description['weight'];
    $this->giver = $description['giver'];
  }

  public function findMatch(array &$wishlist, array &$possibilities) {
    foreach ($wishlist as $index => $item) {
      if ($this->matches($item)) {
        $possibilities[] = $item['name'];
        unset($wishlist[$index]);
      }
    }
  }

  public function matches($item) {
    $return = true;
    foreach ($this as $name => $value) {
      if ($value !== $item[$name]) {
        $return = false;
      }
    }

    return $return;
  }

}
