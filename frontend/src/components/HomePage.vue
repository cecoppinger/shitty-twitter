<template>
  <div class="main-content">
    <header class="jumbotron centered">
      <h1>Shitty Twitter</h1>
      <p>Go ahead, shitty tweet things!</p>
      <ul class="nav justify-content-center">
        <li class="nav-item">
          <router-link class="nav-link btn btn-primary" :to="{ name: 'AllTweets' }">
            Home
          </router-link>
        </li>
        <li class="nav-item">
          <router-link class="nav-link btn btn-primary" :to="{ name: 'PostTweet' }">
            "Tweet"
          </router-link>
        </li>
      </ul>
    </header>
    <div class="all-tweets">
      <router-view class="fade-in" />
    </div>  
  </div>
</template>

<script>
import { mapState, mapActions } from 'vuex';
import AllTweets from './AllTweets';

export default {
  name: 'HomePage',
  created() {
    this.$router.push('/all')
  }
};

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>
.fade-in {
    text-align: center;

    -webkit-animation: fadein 2s; /* Safari, Chrome and Opera > 12.1 */
       -moz-animation: fadein 2s; /* Firefox < 16 */
        -ms-animation: fadein 2s; /* Internet Explorer */
         -o-animation: fadein 2s; /* Opera < 12.1 */
            animation: fadein 2s;
}

@keyframes fadein {
    from { opacity: 0; }
    to   { opacity: 1; }
}

/* Firefox < 16 */
@-moz-keyframes fadein {
    from { opacity: 0; }
    to   { opacity: 1; }
}

/* Safari, Chrome and Opera > 12.1 */
@-webkit-keyframes fadein {
    from { opacity: 0; }
    to   { opacity: 1; }
}

/* Internet Explorer */
@-ms-keyframes fadein {
    from { opacity: 0; }
    to   { opacity: 1; }
}

/* Opera < 12.1 */
@-o-keyframes fadein {
    from { opacity: 0; }
    to   { opacity: 1; }
}
header {
  text-align: center;
  position: relative;
}
li {
  margin: 0 5px;
}
.router-link-active {
  color: gray;
}
</style>
