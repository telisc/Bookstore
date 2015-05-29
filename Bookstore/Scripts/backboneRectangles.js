(function () {
    HighestZinde = 0;
    function getHighestZ() {
        var $divs = $('div');

        $.each($divs, function (index,iitem) {
            if(iitem.id != 'canvas')
            {
                if (iitem.css('z-index') > CONSTANTS.highest_z_index) {
                    CONSTANTS.highest_z_index = iitem.css('z-index');
                }
            }
        });
    };

    var Rectangle = Backbone.Model.extend({});
    var RectangleView = Backbone.View.extend({
        tagName: 'div',
        className: 'rectangle',
        events: {
            click: 'move'
        },
        render: function () {
            this.setDimensions();
            this.setPosition();
            this.setColor();
            return this;
        },
        setDimensions: function () {
            this.$el.css({
                width: this.model.get('width') + 'px',
                height: this.model.get('height') + 'px'
            });
        },
        setPosition: function () {
            var position = this.model.get('position');
            this.$el.css({
                left: position.x,
                top: position.y
            });
        },
        setColor: function () {
            this.$el.css('background-color', this.model.get('color'));
        },
        move: function () {

            ///not working getHighestZ();
            
            this.$el.css('z-index',1);
            this.$el.css('left', this.$el.position().left + 10);
        }

    });

    var models = [
        new Rectangle({
            width: 100,
            height: 70,
            position: {
                x: 10,
                y: 80
            },
            color: 'red'
        }),
            new Rectangle({
                width: 50,
                height: 70,
                position: {
                    x: 20,
                    y: 90
                },
                color: 'green'
            })
    ];

    $.each(models, function (index, model) {
        $('div#canvas').append(new RectangleView({ model: model }).render().el);
    });


})();